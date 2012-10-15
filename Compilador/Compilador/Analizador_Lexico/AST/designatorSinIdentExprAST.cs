using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class designatorSinIdentExprAST : designatorAST
	{
		protected Symbol ident;

		public designatorSinIdentExprAST(Symbol s)
		{
            this.ident = S;
		}

	}
}
