using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class typeSinConCorchetesAST : typeAST
	{
		public typeSinConCorchetesAST(Symbol i)
		{
            this.ident = i;
		}


	}
}
