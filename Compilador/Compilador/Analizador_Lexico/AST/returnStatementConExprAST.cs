using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class returnStatementConExprAST : returnStatementAST
	{
        protected exprAST expr;

		public returnStatementConExprAST(exprAST exp)
		{
            this.expr = exp;
		}
	}
}
