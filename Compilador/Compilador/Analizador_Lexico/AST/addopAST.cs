using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class addopAST : AST
	{
		protected Symbol ident;

		public addopAST(Symbol id)
		{
            this.ident = id;
		}
	}
}
