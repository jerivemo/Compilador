using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class programSinDeclAST : programAST
	{
        protected declsAST methods;

		public programSinDeclAST(Symbol s,declsAST m)
		{
			ident = s;
            methods = m;
		}
	}
}
