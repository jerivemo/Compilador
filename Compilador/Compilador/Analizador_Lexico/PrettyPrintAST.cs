using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Compilador.Analizador_Lexico.AST; 

namespace Compilador.Analizador_Lexico 
{
    class PrettyPrintAST: Visitor
    {
        public void imprimir(AST.AST raiz)
        {
            int d = 0;
            raiz.visit(this, d);
        }
       public void printtab(int n)
       {
    for(int num=n; num != 0; num--)
      Console.WriteLine("+++");
      Console.WriteLine(">");
       }

        // TODOS LOS MÉTODOS PARA IMPRIMIR EL AST

        Object VisitProgramSinNAdaAST(){return null; }

       Object VisitProgramSinMetAST(programSinMetAST decls, Object arg){
            int numaux = ((Int32)arg).GetTypeCode().ToString;
            printtab(numaux); 
            System.out.println(c.getClass().getName());
           if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); 
           |    else{
                printtab(numaux+1);  
                Console.WriteLine(“NULL”);} return null; 
       }

       Object VisitProgramSinDeclAST(programSinDeclAST met, Object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine("NULL");} return null; }

       Object VisitProgramConTodoAST(programConTodoAST todo, Object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnDeclAST(undeclAST unde, Object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarDeclAST(varDeclAST var, Object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitParseConsDeclAST(constDeclAST var, Object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitParseblockSinStatementAST(blockSinStatementAST b, Object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitBreakStatementAST(breakStatementAST b, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitClassConVarDeclAST(classConVarDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitClassSinVarDeclAST(classSinVarDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitComaStatementAST(comaStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitCondFactAST(condFactAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitConditionAST(conditionAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitCondTermAS(condTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisiConstDeclAST(constDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorAS(designatorAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorConIdentExprAST(designatorConIdentExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorSinIdentExprAST(designatorSinIdentExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorStatementActParsAST(designatorStatementActParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorStatementAsignacionAST(designatorStatementAsignacionAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorStatementAST(designatorStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorStatementAumentoAST(designatorStatementAumentoAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorStatementDecrementoAST(designatorStatementDecrementoAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorStatementSinActParsAST(designatorStatementSinActParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitDesignatorStatementUnActParsAST(designatorStatementUnActParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitExprAddopTermAST(exprAddopTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitExpreSoloTermAST(expreSoloTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitExprNegativaAddopTermAST(exprNegativaAddopTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitExprNegativaTermAST(exprNegativaTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorBoolAST(factorBoolAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorCharConstAST(factorCharConstAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorDesignatorAST(factorDesignatorAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorDesignatorConActParsAST(factorDesignatorConActParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorDesignatorSinActParsAST(factorDesignatorSinActParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorExprAST(factorExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorNewConExprAST(factorNewConExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }
       Object VisitfactorNewSinExprAST(factorNewSinExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFactorNumberAST(factorNumberAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitFormParsAST(formParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitForStatementAST(forStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitForStatementConCondFuntAST(forStatementConCondFuntAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitForStatementConConditionAST(forStatementConConditionAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitForStatementConFuntionAST(forStatementConFuntionAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitForStatementSoloDeclAST(forStatementSoloDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }
       Object VisitIfStatementAST(ifStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitIfStatementConELseAS(ifStatementConELseAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitIfStatementSinELseAST(ifStatementSinELseAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitMethodTipoConFormDeclsAST(methodTipoConFormDeclsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }
       Object VisitMethodTipoSinFormDeclsAST(methodTipoSinFormDeclsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitMethodTipoSinFormParsAST(methodTipoSinFormParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitMethodTipoSinVarDeclAST(methodTipoSinVarDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitMethodVoidConFormDeclsAST(methodVoidConFormDeclsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }
       Object VisitMethodVoidSinFormDeclsAST(methodVoidSinFormDeclsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitMethodVoidSinFormParsAST(methodVoidSinFormParsAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitMethodVoidSinVarDeclAST(methodVoidSinVarDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitMulopAST(mulopAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       // Object VisitProgramConTodoAST(programConTodoAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       //Object VisitProgramSinDeclAST(programSinDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       // Object VisitProgramSinMetAST(programSinMetAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitProgramSinNadaAST(programSinNadaAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitReadStatementAST(readStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitRelopAST(relopAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitReturnStatementConExprAST(returnStatementConExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitReturnStatementSinExprAST(returnStatementSinExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitTermConMulopFactorAST(termConMulopFactorAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitTermSinMulopFactorAST(termSinMulopFactorAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitTypeConCorchetesAST(typeConCorchetesAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitTypeSinConCorchetesAST(typeSinConCorchetesAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnAddopTermAST(unAddopTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnCondFactAST(unCondFactAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnCondTermAST(unCondTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUndeclAST(undeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnExprAST(unExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnIdentAST(unIdentAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnIdentExpreConExprAST(unIdentExpreConExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnIdentExpreConIdentAST(unIdentExpreConIdentAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnMulopTermAST(unMulopTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnStatementAST(unStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitUnTipoIdentAST(unTipoIdentAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarAddopTermAST(varAddopTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarCondFactAST(varCondFactAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarCondTermAST(varCondTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       //Object VisitVarDeclAST(varDeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarExprAST(varExprAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarIdentAST(varIdentAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarIdentExpreAST(varIdentExpreAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarMulopTermAST(varMulopTermAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarsdeclAST(varsdeclAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarStatementAST(varStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitVarTipoIdentAST(varTipoIdentAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitWhileStatementAST(whileStatementAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitWriteStatementConNumAST(writeStatementConNumAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }

       Object VisitWriteStatementSinNumAST(writeStatementSinNumAST var, object arg){      int numaux = ((Integer)arg).intValue(); printtab(numaux); System.out.println(c.getClass().getName());  if(c.- !=null)  c.-.visit(this,new Integer(numaux+1)); else{printtab(numaux+1);  Console.WriteLine(“NULL”);} return null; }





    }
}
