using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class programSinMetAST : programAST
	{
        protected declsAST declaration;

		public programSinMetAST(Symbol s,declsAST d)
		{
			ident = s;
            declaration = d;
		}
	}
}
