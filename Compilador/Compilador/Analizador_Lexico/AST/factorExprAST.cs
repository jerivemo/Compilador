using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorExprAST : factorAST
	{
		exprAST expr;

		public factorExprAST(exprAST e)
		{
            expr = e;
		}

		
	}
}
