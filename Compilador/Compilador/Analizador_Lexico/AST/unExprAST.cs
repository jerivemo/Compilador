using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unExprAST : listExprAST
	{
		exprAST expr;

		public unExprAST(exprAST e)
		{
            expr = e;
		}


	}
}
