using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unIdentAST : identListAST
	{
		Symbol ident;

		public unIdentAST(Symbol s)
		{
            ident = s;		
		}


	}
}
