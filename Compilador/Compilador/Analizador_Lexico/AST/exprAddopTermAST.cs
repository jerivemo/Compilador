using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class exprAddopTermAST : exprAST
	{
		listAddopTermAST listAddopTerm;
		termAST term;

		public exprAddopTermAST(termAST t, listAddopTermAST l )
		{
            listAddopTerm = l;
            term=t;
		}


	}
}
