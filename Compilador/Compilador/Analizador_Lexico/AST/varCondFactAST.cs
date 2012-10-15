using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varCondFactAST : listCondFactAST
	{
		listCondFactAST h1;
		listCondFactAST h2;

		public varCondFactAST(listCondFactAST hh1, listCondFactAST hh2)
		{
			h1 = hh1;
            h2= hh2;
		}


	}
}
