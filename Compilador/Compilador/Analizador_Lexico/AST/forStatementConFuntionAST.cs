using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class forStatementConFuntionAST : forStatementAST
	{
		exprAST funtion;

        public forStatementConFuntionAST(exprAST d, exprAST f, statementAST s)
		{
            this.decl = d;
            this.funtion = f;
            this.statement = s; 
		}
	}
}
