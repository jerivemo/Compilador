//IMPORTES:
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Runtime;
using Compilador.Analizador_Lexico.AST;

 namespace Compilador.Analizador_Lexico
{
    class Parser
    {
        //////////////////////////////////////////////////
        //ATRIBUTOS O VARIABLES:
        //////////////////////////////////////////////////
        private Symbol currentToken;
        private Scanner scanner;
        public programAST raiz;
        //////////////////////////////////////////////////
        //CONSTRUCTOR:
        //////////////////////////////////////////////////
        public Parser(Scanner s)
        {
            scanner = s;
            raiz = null;
        }

        //////////////////////////////////////////////////
        //METODOS:
        //////////////////////////////////////////////////

        //verificar el token actual y obtener el siguiente token:
        private void accept(int expectedKind)
        {
            try
            {
                if (currentToken.sym == expectedKind)
                    currentToken = scanner.nextToken();
                else
                    Console.WriteLine("ERROR SINTÁCTICO. Se esperaba " + expectedKind + " pero en su lugar viene: " + currentToken.sym);
            }
            catch (Exception e)
            { }
        }
        //Este metodo solo se utiliza cuando se usan palabras reservadas.
        private void accept(int expectedKind, String Err)
        {
            try
            {
                if (currentToken.sym == expectedKind)
                    currentToken = scanner.nextToken();
                else
                    error(currentToken, Err);
            }
            catch (Exception e)
            { }
        }

        private void acceptIt()
        {
            try
            {
                currentToken = scanner.nextToken();
            }
            catch (Exception e)
            { }
        }

        //METODO PRINCIPAL: INICIA EL ANALISIS SINTACTICO:
        public void parse()
        {
            acceptIt(); //obtiene el primer token
            raiz = parseProgram();
            
        }

        public void error(Symbol currentToken, String Exp)
        {
            Console.WriteLine("Error Sintáctico en fila: " + currentToken.left
                              + " y columna " + currentToken.right +
                            ". Se esperaba que viniera " + Exp + " pero en su lugar viene "
                           + currentToken.value);
        }

        //METODOS PRIVADOS DE PARSING PARA CADA NO TERMINAL:


        public programAST parseProgram()
        {
            declAST   conD,conD2;
            declAST   varD,varD2;
            declAST   claD, claD2;
            declAST   metD, metD2;
            declsAST result=null;
            declsAST temp=null;
            Boolean ind = false;
            Boolean var = false;
            Boolean var2 = false;
            Symbol symtemp;
            if (currentToken.sym == sym.CLASS)
            {
                accept(sym.CLASS, "class");
                symtemp = currentToken;
				accept(sym.ID, "ident");
                while (currentToken.sym == sym.CONST || currentToken.sym == sym.ID || currentToken.sym == sym.CLASS)
                {
                    var=true;
                    switch (currentToken.sym)
                    {
                        case sym.CONST:
                            {
                                if (ind == false)
                                {
                                    conD = parseConstDecl();
                                    result=new undeclAST(conD);
                                    
                                    
                                    ind = true;
                                }
                                else {
                                    conD2 = parseConstDecl();
                                    temp = new undeclAST(conD2);
                                    result = new varsdeclAST(result, temp);
                                    
                                }
                                break;
                            }
                        case sym.ID:
                            {
                                if (ind == false)
                                {
                                    varD = parseVarDecl();
                                    result = new  undeclAST(varD);
                                    ind = true;
                                }
                                else
                                {
                                    varD2 = parseVarDecl();
                                    temp = new undeclAST(varD2);
                                    result = new varsdeclAST(result, temp);

                                }

                                break;
                            }
                        case sym.CLASS:
                            {
                                if (ind == false)
                                {
                                    claD = parseClassDecl();
                                    result = new undeclAST(claD);
                                    ind = true;
                                    
                                }
                                else
                                {
                                    claD2 = parseClassDecl();
                                    temp = new undeclAST(claD2);
                                    result = new varsdeclAST(result, temp);
                                }
                                break;
                            }
                           // return result;
                    }
                    }

                    accept(sym.COR_A, "{");
                    while (currentToken.sym == sym.ID || currentToken.sym == sym.VOID)
                    {
                        var2=true;
                        if (ind == false)
                        {
                            metD = parseMethodDecl();
                            result = new undeclAST(metD);
                            ind = true;
                        }
                        else {
                            metD2 = parseMethodDecl();
                            temp = new undeclAST(metD2);
                            result = new varsdeclAST(result, temp);
                        }
                    }
                    accept(sym.COR_C, "}");
                    if (var==false && var2==false) {
                        return new programSinNadaAST(symtemp);
                    }
                    if (var==true && var2==false)
                    {
                        return  new programSinMetAST(symtemp,result);
                    }
                    if (var=false && var2==true)
                    {
                        return new programSinDeclAST(symtemp,result);
                    }
                    if (var==true && var2==true)
                    {
                        return new programConTodoAST(symtemp,result);
                    }
                    
            }
            else error(currentToken, "CLASS");
                 return null;
        }



        public declAST parseConstDecl()
        {  
            accept(sym.CONST);
            typeAST type= parseType();
            Symbol temp= currentToken;
           
            accept(sym.ID);
            if (currentToken.sym == sym.IGUAL)
            {
                acceptIt();
                Symbol temp2;
                if (currentToken.sym == sym.NUM)
                {
                    
                    temp2=currentToken;
                    acceptIt();
                    return new constDeclAST(type,temp2);

                    if (currentToken.sym == sym.PYCOMA)
                    {
                         acceptIt();
                        
                    }
                    else
                        error(currentToken, ";");
                }
                if (currentToken.sym == sym.CHARCONS)
                {
                    
                    temp2 = currentToken;
                    acceptIt();
                    return new constDeclAST(type,temp2);

                    if (currentToken.sym == sym.PYCOMA){
                        accept(sym.PYCOMA);
                       return new constDeclAST(type,temp2);
                    }
                    else
                        error(currentToken, ";");

                }
                else
                    error(currentToken, "TIPO: NUM O CHARCONS");


            }
            else
                error(currentToken, "=");
            return null;
        }


        public declAST parseVarDecl()
        {
            typeAST type = parseType();
            identListAST result= new unIdentAST(currentToken);
            accept(sym.ID);
            while (currentToken.sym == sym.COMA)
            {
                acceptIt();
                unIdentAST temp = new unIdentAST(currentToken);
                result = new varIdentAST(result, temp);
                accept(sym.ID);
            }
            accept(sym.PYCOMA);
            return new varDeclAST(type,result);
        }
        public declAST parseClassDecl()
        {
            declsAST temp=null;
             declsAST result=null;
            declAST varD;
            accept(sym.CLASS, "CLASS");
            Symbol temptoken = currentToken;
            accept(sym.ID);
            accept(sym.COR_A, "{");
            if (currentToken.sym == sym.COR_C)
            {
               accept(sym.COR_C, "}");
               return new classSinVarDeclAST(temptoken);
            }
            else
            {   Boolean ind=false;
                while (currentToken.sym == sym.ID)
                {
                    if(ind==false)
                    {
                   varD = parseVarDecl();
                   result = new undeclAST(varD);
                    }
                    else
                    {
                   varD = parseVarDecl();
                   temp = new undeclAST(varD);
                   result = new varsdeclAST(temp,result);

               }
                  //revisar
                    
                }
                accept(sym.COR_C, "}");
            }


            return new classConVarDeclAST(result,temptoken);

        }

        public declAST parseMethodDecl()
        {
            declAST varD=null;
            declsAST varD2=null;
            declsAST varD3 = null;
            Symbol temp = currentToken;
            typeAST type=null;
           if (currentToken.sym == sym.ID || currentToken.sym == sym.VOID)
            {
               
                if (currentToken.sym == sym.ID)
                {
                   
                   type = parseType();
                }    
                    
               if (currentToken.sym == sym.VOID)
                {
                    accept(sym.VOID, "void");
                }
                  temp = currentToken;
                  accept(sym.ID, "ident");
                  accept(sym.P_ABI, "(");
                  formParsAST formP=null;
                if (currentToken.sym == sym.ID)
                {
                    formP=parseFormPars();
                }
                else
                    accept(sym.P_CER, ")");

                Boolean ind = false;
                while (currentToken.sym == sym.ID)
                {
                    if (ind == false)
                    {
                        varD = parseVarDecl();
                        varD2 = new undeclAST(varD);
                        varD3 = varD2;
                        ind = true;
                    }
                    else {

                        varD = parseVarDecl();
                        varD2 = new undeclAST(varD);
                        varD3 = varD2;
                        varD2 = new varsdeclAST(varD2,varD3);
                    }
                    
                }
                blockAST parseB=parseBlock();
                if(type==null && formP==null)
                {
                    if (ind == true)
                    {
                        return new methodVoidSinFormDeclsAST(temp);
                    }
                    else {
                       return new  methodTipoSinFormParsAST(temp, varD2);
                       // return voidSinFormParsAST(temp, varD, parseB);
                    }
                }
                if (type == null && varD == null)
                {
                    return new methodTipoSinVarDeclAST(temp,formP); 
                   // return voidSinVarDeclAST(temp,formP,parseB);
                }
                if (type == null && varD != null && formP != null)
                {
                    if (ind == true)


                        return new methodVoidConFormDeclsAST(varD2, formP, temp);
                    // return voidConForm_DeclsAST(temp, varD2, formP, parseB); 

                    else //return voidConForm_DeclsAST(temp, varD, formP, parseB);
                        return new methodVoidSinVarDeclAST(formP, temp);
                }

                if (type == null && varD == null && formP == null)
                {

                    return new methodVoidSinFormDeclsAST(temp);
                }

                
            }
           return null;
        }
        public formParsAST parseFormPars()
        {
           listTipoIdentAST temp=null;
           listTipoIdentAST result=null;
           typeAST type=parseType();
           Symbol tempsymbol = currentToken;
           temp = new unTipoIdentAST(tempsymbol,type);
           accept(sym.ID, "Identificador");
           
            while (currentToken.sym == sym.COMA)
            {
                accept(sym.COMA, ",");
                tempsymbol = currentToken;
                type = parseType();
                temp =  new unTipoIdentAST(tempsymbol,type);
                result = new varTipoIdentAST(result, temp);
         }
            return new formParsAST(result);
        }

        public typeAST parseType()
        {
            Symbol tempsymbol = currentToken;
            accept(sym.ID, "Identificador");
			/*if(currentToken.sym == sym.ID)
					accept(sym.ID);
					else(currentToken.sym == sym.VOID)
					accept(sym.VOID);*/ //NO VA AQUI...YA LO HACE EN EL PARSE_TYPE ARRIBA......
            if (currentToken.sym == sym.C_ABI)
            {
                accept(sym.C_ABI, "[");
                if (currentToken.sym == sym.C_CER)
                {
                    accept(sym.C_CER, "]");
                    return new typeConCorchetesAST(tempsymbol);
                }
                else
                {
                    //ERROR
                    error(currentToken, "]");
                    return null;
                }
            }
            else
                return new typeSinConCorchetesAST(tempsymbol);
        }

        public blockAST parseBlock()
        {
            listStatementsAST temp=null;
            listStatementsAST result=null;
            statementAST parS;
            accept(sym.COR_A, "{");
            Boolean ind =false;
            while (currentToken.sym == sym.ID)
            {
                if (ind == false)
                {
                    parS = parseStat();
                    temp = new unStatementAST(parS);
                    ind = true;
                }
                else 
                {
                    parS = parseStat();
                    temp = new unStatementAST(parS);
                    result = new varStatementAST(result,temp);
                }
            }
            accept(sym.COR_C, "}");
            if (ind == false)
            {
                return new blockSinStatementAST();

            }
            else
            {
                if (result == null) {
                    return new blockConStatementAST(temp);
                }
                else return new blockConStatementAST(result);
                  
            }
        }

        public statementAST parseStat()
        { //Statement
            //case id
            designatorAST desig = null;
            exprAST expr = null;
            actParsAST actP = null;
            designatorStatementAumentoAST aum = null;
            designatorStatementDecrementoAST decr = null;
            Boolean actPBoo = false;
            //case if
            conditionAST condi = null;
            statementAST stat = null;
            statementAST stat2 = null;
            Boolean elseBoo = false;
            listStatementsAST tempStat,tempStat2, result;
            exprAST forexpr1 = null;
            conditionAST forexpr2 = null;
            exprAST forexpr3 = null;
            statementAST forstat = null;
            switch (currentToken.sym)
            {
                case sym.ID:
                    {
                       desig=parseDesignator();
                        switch (currentToken.sym)
                        {
                            case sym.IGUAL:
                                {
                                    acceptIt();
                                    expr=parseExpr();
                                    break;
                                }
                            case sym.P_ABI:
                                {
                                    acceptIt();
                                    if (currentToken.sym == sym.RES || currentToken.sym == sym.ID || currentToken.sym == sym.NUM || currentToken.sym == sym.CHARCONS || currentToken.sym == sym.TRUE || currentToken.sym == sym.FALSE || currentToken.sym == sym.NEW || currentToken.sym == sym.P_ABI)
                                    {
                                       actP=parseActPars();
                                       actPBoo = true;
                                    }
                                    accept(sym.P_CER, ")");
                                    break;
                                }
                            case sym.SUM_SUM:
                                {
                                    aum = new designatorStatementAumentoAST();
                                    acceptIt();
                                    break;
                                }
                            case sym.IGU_IGU:
                                {
                                    decr = new designatorStatementDecrementoAST();
                                    acceptIt();
                                    break;
                                }
                                accept(sym.PYCOMA, ";");
                            //Designator ( "=" Expr | "(" [ ActPars ] ")" | "++" | "--" ) ";"
                        }
                        if (expr != null)
                        {
                            return new designatorStatementAsignacionAST(expr);
                        }
                        else
                        
                            if (actP != null)
                            {
                                return new designatorStatementUnActParsAST(actP); //revisar
                            }
                        
                        else
                       
                        if (actPBoo == true) 
                        {
                            return new designatorStatementUnActParsAST(actP); //revisar
                        }
                       
                        else
                        
                        if (actPBoo==false)        //analizar posible fallo
                        {
                            return new designatorStatementSinActParsAST();
                        }
                        

                        break;
                    }

                case sym.IF:
                    {   
                        accept(sym.IF, "if");
                        accept(sym.P_ABI, "(");
                        condi=parseCondition();
                        accept(sym.P_CER, ")");
                        stat=parseStat();
                        //tempStat = new unStatementAST(stat);
                        if (currentToken.sym == sym.ELSE)
                        {
                            elseBoo=true;
                            stat2 = parseStat();
                            
                        }
                        if (elseBoo == true)
                        {
                           return new ifStatementConELseAST (condi,stat,stat2);

                        }
                        else {
                          return new ifStatementSinELseAST(condi,stat);
                               }
                        break;
                    }

                case sym.FOR:
                    {
                        accept(sym.FOR, "for");
                        accept(sym.P_ABI, "(");
                        forexpr1=parseExpr();
                        accept(sym.PYCOMA, ";");
                        if (currentToken.sym == sym.RES || currentToken.sym == sym.ID || currentToken.sym == sym.NUM || currentToken.sym == sym.CHARCONS || currentToken.sym == sym.TRUE || currentToken.sym == sym.FALSE || currentToken.sym == sym.NEW || currentToken.sym == sym.P_ABI)
                        {

                            forexpr2 = parseCondition();
                        }
                        accept(sym.PYCOMA, ";");
                        if (currentToken.sym == sym.RES || currentToken.sym == sym.ID || currentToken.sym == sym.NUM || currentToken.sym == sym.CHARCONS || currentToken.sym == sym.TRUE || currentToken.sym == sym.FALSE || currentToken.sym == sym.NEW || currentToken.sym == sym.P_ABI)
                        {
                            forexpr3=parseExpr();
                        }
                        accept(sym.PYCOMA, ";");
                       forstat=parseStat();
                        if(forexpr2!=null && forexpr3==null){
                            return new forStatementConConditionAST(forexpr1, forexpr2,forstat);
                        }

                        if (forexpr3 != null && forexpr2==null)
                        {
                            return new forStatementConFuntionAST(forexpr1, forexpr3, forstat);
                        }
                        if (forexpr3 == null && forexpr2==null)
                        {
                            return new forStatementSoloDeclAST(forexpr1, forstat);
                        }
                        if (forexpr3 != null && forexpr2!=null)
                        {
                            return new forStatementConCondFuntAST(forexpr1, forexpr2, forexpr3, forstat);
                        }
                        
                        
                        break;

                    }

                case sym.WHILE:
                    {
                        accept(sym.WHILE, "WHILE");
                        accept(sym.P_ABI, "(");
                        condi = parseCondition();
                        accept(sym.P_CER, ")");
                        stat = parseStat();
                         return new whileStatementAST(condi,stat);
                        break;
                    }
                case sym.BREAK: {
                    accept(sym.PYCOMA);
                break;
                }
                case sym.RETURN:
                    {   Boolean ind=false;
                        acceptIt();
                        if (currentToken.sym == sym.RES || currentToken.sym == sym.ID || currentToken.sym == sym.NUM || currentToken.sym == sym.CHARCONS || currentToken.sym == sym.TRUE || currentToken.sym == sym.FALSE || currentToken.sym == sym.NEW || currentToken.sym == sym.P_ABI)
                        {
                           expr=parseExpr();
                            ind=true;
                        }
                        accept(sym.PYCOMA, ";");
                        if (ind == true)
                        {
                            return new returnStatementConExprAST(expr);
                        }
                        else {

                            return new returnStatementSinExprAST();
                        }
                        break;
                    }

                case sym.READ:
                    {
                        acceptIt();
                        accept(sym.P_ABI, "(");
                       desig=parseDesignator();
                      
                        accept(sym.P_CER, ")");
                        accept(sym.PYCOMA, ";");
                        return new readStatementAST(desig); //revisar este return
                        break;

                    }
                case sym.WRITE:
                    {
                        accept(sym.P_ABI, "(");
                        expr=parseExpr();
                        Symbol tempsimbol=null;
                        if (currentToken.sym == sym.COMA)
                        {
                            accept(sym.COMA, ",");
                            tempsimbol=currentToken;
                            accept(sym.NUM, "number");
                           }
                        accept(sym.P_CER, ")");
                        accept(sym.PYCOMA, ";");
                        if (tempsimbol != null)
                        {
                            return new writeStatementConNumAST(tempsimbol, expr);
                        }
                        else
                        {
                            return new writeStatementSinNumAST(expr);
                        }
                        //                    "write" "(" Expr [ "," number ] ")" ";"
                       

                    }
                case sym.COR_A: 
                    {
                    parseBlock(); 
                    break; 
                     }
                case sym.PYCOMA:
                    { 
                acceptIt();
                break;
                     }

            }


            return null;

        }
        public actParsAST parseActPars()
        {
            listExprAST temp=null;
            listExprAST temp2 = null;
            listExprAST result = null;
            exprAST expr=null;
            if (currentToken.sym == sym.RES || currentToken.sym == sym.ID || currentToken.sym == sym.NUM || currentToken.sym == sym.CHARCONS || currentToken.sym == sym.TRUE || currentToken.sym == sym.FALSE || currentToken.sym == sym.NEW || currentToken.sym == sym.P_ABI)
            {
               
                expr = parseExpr();
                temp= new unExprAST(expr);
                Boolean ind=false;
                while (currentToken.sym == sym.COMA)
                {
                    if(ind==false){
                    acceptIt();
                    expr=parseExpr();
                    temp2 = new unExprAST(expr);
                    result = new varExprAST(temp2, temp);
                    ind=true;
                    }
                    else{
                    acceptIt();
                    expr=parseExpr();
                    temp2 = new unExprAST(expr);
                    result = new varExprAST(result, temp2);
                   }
                }
                if (temp2 == null && result == null) {

                    return new  actParsAST(temp);
                }
  
                return new actParsAST(result);
        }
            else
            {
                error(currentToken, " '-' o 'ID'");
                return null;
            }
        }


        public conditionAST parseCondition()
        {
            listCondTermAST temp = null;
            listCondTermAST temp2 = null;
            listCondTermAST result = null;
            condTermAST cndT = null;
            condTermAST expr=null;

            //Condition = CondTerm { "||" CondTerm }
            cndT=parseCndTerm();
            temp = new unCondTermAST(cndT);
            Boolean ind = false;
            while (currentToken.sym == sym.O_O)
            {
                acceptIt();
                if (ind == false)
                {
                    acceptIt();
                    expr = parseCndTerm();
                    temp = new unCondTermAST(expr);
                    result = new varCondTermAST(temp2, temp);
                    ind = true;
                }
                else
                {
                    acceptIt();
                    expr = parseCndTerm();
                    temp2 = new unCondTermAST(expr);
                    result = new varCondTermAST(result, temp2);
                }

              }
            if (result == null)
            {
                return new conditionAST(temp);
            }
            else return new conditionAST(result);
        }

        public condTermAST parseCndTerm()
        {
            listCondFactAST temp = null;
            listCondFactAST temp2 = null;
            listCondFactAST result = null;
            condFactAST cndT = null;
            condFactAST expr=null;
            //CondTerm= CondFact { "&&" CondFact }
            cndT = parseCndFac();

            temp = new unCondFactAST(cndT);
            Boolean ind = false;
            while (currentToken.sym == sym.Y_Y)
            {
                acceptIt();
                if (ind == false)
                {
                    acceptIt();
                    expr = parseCndFac();
                    temp = new unCondFactAST(expr);
                    result = new varCondFactAST(temp2, temp);
                    ind = true;
                }
                else
                {
                    acceptIt();
                    expr = parseCndFac();
                    temp2 = new unCondFactAST(expr);
                    result = new varCondFactAST(result, temp2);
                }

            }
            if (result == null)
            {
                return new condTermAST(temp);
            }
            else return new condTermAST(result);
        }

        public condFactAST parseCndFac()
        {   //CondFact
            //CondFact = Expr Relop Expr
          exprAST expr=parseExpr();
          relopAST rel=parseRelop();
          exprAST expr2= parseExpr();
          return new condFactAST(expr, rel, expr2);
        }
        public exprAST parseExpr()
        {
            listAddopTermAST temp=null;
            listAddopTermAST result=null;
            termAST term = null;
            addopAST addop = null;
            termAST term2 = null;
            //Expr = [ "-" ] Term { Addop Term }
            Boolean ind = false;
            Boolean ind2 = false;
            if (currentToken.sym == sym.RES)
            {
                acceptIt();
                ind = true;
            }
           term = parseTerm();
            while (currentToken.sym == sym.SUM || currentToken.sym == sym.RES)
            {
                if (ind2 == false)
                {

                    addop = parseAddop();
                    term2 = parseTerm();
                    result = new unAddopTermAST(addop, term2);
                    ind2 = true;

                }
                else
                {
                    addop = parseAddop();
                    term2 = parseTerm();
                    temp = new unAddopTermAST(addop, term2);
                    result = new varAddopTermAST(result, temp);
                }
               
            }
            if (ind == false && result == null) {

                return new expreSoloTermAST(term);
            }
            else if (ind == true && result == null)
            {

                return new exprNegativaTermAST(term);
            }
            else if (ind == false && result !=null)
             {

                return new exprAddopTermAST(term,result);
             }
            else if (ind == true && result != null)
            {

                return new exprNegativaAddopTermAST(result,term);
            }
            return null;
        }

        public termAST parseTerm()
        {
            listMulopFactorAST temp=null;
            listMulopFactorAST result=null;
            factorAST fact = null;
            mulopAST mul = null;
            factorAST fact2 = null;
         
            fact=parseFactor();
            Boolean ind=false;

            while (currentToken.sym == sym.POR | currentToken.sym == sym.DIV | currentToken.sym == sym.PORC)
            {
               if (ind == false)
                {

                    mul = parseMulop();
                    fact2 = parseFactor();
                    result = new unMulopTermAST(mul, fact2);
                    ind = true;
               }
                else
                {
                    mul = parseMulop();
                    fact2 = parseFactor();
                    temp = new unMulopTermAST(mul,fact2);
                    result = new varMulopTermAST(result,temp);
                }

            }
            if(ind==false)
            {
            
            return new termSinMulopFactorAST(fact);
            }

            else  return new termConMulopFactorAST(fact,result);
        }

        public factorAST parseFactor()
        {
            designatorAST desi=null;
            actParsAST actP=null;
            exprAST expr=null;
          switch (currentToken.sym)
            {
                case sym.ID:
                    {
                        desi=parseDesignator();
                        if (currentToken.sym == sym.P_ABI)
                        {
                            accept(sym.P_ABI, "(");
                            if (currentToken.sym == sym.COMA)
                            {
                                actP=parseActPars();
                            }
                            accept(sym.P_CER, ")");
                        }
                       
                        if(actP==null)
                        
                        return new factorDesignatorSinActParsAST(desi);
                        
                        else return new  factorDesignatorConActParsAST(desi,actP);

                        break;
                    }
                case sym.NUM:
                    {
                        Symbol num = currentToken;
                        accept(sym.NUM, "NUMERO");
                        return new factorNumberAST(num);
                       
                    }
                case sym.CHARCONS:
                    {
                        Symbol charc = currentToken;
                        accept(sym.CHARCONS, "CHARCONS");
                        return new factorCharConstAST(charc);
                       
                    }
                case sym.TRUE: {
                    Symbol temp=currentToken;
                    accept(sym.TRUE, "TRUE");
                    return new factorBoolAST(temp);
                  
                }
                case sym.FALSE: {
                    Symbol temp=currentToken;
                    accept(sym.FALSE, "FALSE");
                    return new factorBoolAST(temp);
                   
                }
                case sym.NEW: {
                        acceptIt();
                        Symbol temp= currentToken;
                        accept(sym.ID, "ident");
                        if (currentToken.sym == sym.C_ABI)
                        {
                            acceptIt();
                            expr=parseExpr();
                            accept(sym.C_CER, "]");
                        }
                    if(expr==null)
                    return new factorNewSinExprAST(temp);

                    else return new factorNewConExprAST(temp,expr);

                    
                    }
                case sym.P_ABI:
                    {
                        expr=parseExpr();
                        accept(sym.P_CER);
                       return new  factorExprAST(expr);
                     
                    }

            }
          return null;
        }

        public designatorAST parseDesignator()
        {//Designator
            //Designator = ident { "." ident | "[" Expr "]" }
            listIdentExprAST temp = null;
             listIdentExprAST result=null;
             Symbol tempsimbol2=null;
            exprAST expr=null;
            Symbol tempsimbol=currentToken;
            accept(sym.ID, "ident");
            Boolean ind=false;
            Boolean ind2=false;
            while (currentToken.sym == sym.PUNTO || currentToken.sym == sym.C_ABI)
            {
                if (currentToken.sym == sym.PUNTO)
                {
                    if(ind==false){
                    acceptIt();
                    tempsimbol2=currentToken;
                    accept(sym.ID, "ident");
                    result= new unIdentExpreConIdentAST(tempsimbol2);
                    ind=true;

                     }
                    else
                    {
                    acceptIt();
                    tempsimbol2=currentToken;
                    accept(sym.ID, "ident");
                    temp= new unIdentExpreConIdentAST(tempsimbol2);
                    result = new varIdentExpreAST(result,temp);

                    } 
                }
                else
                {
                                    
                    if(ind2==false)
                    {
                   acceptIt();
                   expr=parseExpr();
                   accept(sym.C_CER, "]");
                   result= new unIdentExpreConExprAST(expr);
                   ind2=true;
                    }
                    else
                    {
                    acceptIt();
                    expr=parseExpr();
                    accept(sym.C_CER, "]");
                    temp= new unIdentExpreConExprAST(expr);
                    result = new varIdentExpreAST(result,temp);

                        } 
                    }

                    }
            
            if(tempsimbol2==null && result==null)
            {
                return new designatorSinIdentExprAST(tempsimbol);
            }
            else return new designatorConIdentExprAST(tempsimbol,result);

        }
        public relopAST parseRelop()
        {
            Symbol temp;
            if (currentToken.sym == sym.IG_IG || currentToken.sym == sym.DIF_IG || currentToken.sym == sym.MAY ||
                currentToken.sym == sym.MAY_IG || currentToken.sym == sym.MEN || currentToken.sym == sym.MEN_IG)
            {
                temp=currentToken;
                
                acceptIt();
                return new relopAST(temp);
            }
            else
            {
                error(currentToken, "'==' o '!=' o '>' o '>=' o '<' o '<=' ");
                return null;
            }
        }
        public addopAST parseAddop()
        {Symbol temp;
            if (currentToken.sym == sym.SUM || currentToken.sym == sym.RES)
            {  temp=currentToken;
                acceptIt();
                return new addopAST(temp);
            }
            else
            {
                error(currentToken, "'+' o '-' ");
                return null;
            }

        }
        public mulopAST parseMulop()
        {Symbol temp;
            if (currentToken.sym == sym.PORC || currentToken.sym == sym.DIV || currentToken.sym == sym.POR)
            {
                temp=currentToken;
                acceptIt();
                return new mulopAST(temp);
            }
            else
            {
                error(currentToken, "'*' o '/' o '%' ");
                return null;
            }
        }
    }
}