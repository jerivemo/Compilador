using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class relopAST : AST
	{
        protected Symbol ident;

		public relopAST(Symbol sym)
		{
            this.ident = sym;
		}
	}
}
