using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorNewConExprAST : factorNewAST
	{
		exprAST expr;

		public factorNewConExprAST(Symbol s,exprAST e)
		{
            this.ident = s;
            expr = e;
		}
	}
}
