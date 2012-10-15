using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varIdentAST : identListAST
	{
		identListAST h1;
		identListAST h2;

		public varIdentAST(identListAST hh1, identListAST hh2)
		{
            h1 = hh1;
            h2 = hh2;
		}


	}
}
