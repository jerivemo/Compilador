using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class exprNegativaAddopTermAST : exprAST
	{
		listAddopTermAST listAddopTerm;
		termAST term;

		public exprNegativaAddopTermAST(listAddopTermAST l, termAST t)
		{
            listAddopTerm = l;
            term = t;
		}

		
	}
}
