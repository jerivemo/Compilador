using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class writeStatementSinNumAST : writeStatementAST
	{
		public writeStatementSinNumAST(exprAST e)
		{
            this.expr = e;          
		}

	}
}
