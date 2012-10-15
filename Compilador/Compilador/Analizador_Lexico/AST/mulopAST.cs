using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class mulopAST : AST
	{
        protected Symbol ident;

		public mulopAST(Symbol sym)
		{
            this.ident = sym;
		}
	}
}
