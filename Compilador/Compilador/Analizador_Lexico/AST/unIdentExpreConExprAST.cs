using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unIdentExpreConExprAST : unIdentExpreAST
	{
		exprAST expr;

		public unIdentExpreConExprAST( exprAST ex)
		{
            expr = ex;
		}

		public Object visit(Visitor v, Object arg)
		{
			throw new NotImplementedException();
		}
	}
}
