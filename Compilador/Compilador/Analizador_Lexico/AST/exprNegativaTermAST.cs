using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class exprNegativaTermAST : exprAST
	{
		termAST term;

		public exprNegativaTermAST(termAST t)
		{
            term = t;
		}

		
	}
}
