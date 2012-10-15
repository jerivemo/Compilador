using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class typeConCorchetesAST : typeAST
	{
		public typeConCorchetesAST(Symbol i)
		{
            this.ident = i;
		}
	}
}
