using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class writeStatementConNumAST : writeStatementAST
	{
		Symbol ident;

		public writeStatementConNumAST(Symbol i, exprAST e)
		{
            ident = i;
            this.expr = e; 
		}

	}
}
