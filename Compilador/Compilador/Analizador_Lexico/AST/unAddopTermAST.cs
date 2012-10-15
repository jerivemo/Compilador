using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unAddopTermAST : listAddopTermAST
	{
		addopAST addop;
		termAST term;

		public unAddopTermAST(addopAST a, termAST t)
		{
            addop = a;
            term = t;
		}

		
	}
}
