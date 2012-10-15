using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varCondTermAST : listCondTermAST
	{
		listCondTermAST h1;
		listCondTermAST h2;

		public varCondTermAST(listCondTermAST hh1, listCondTermAST hh2)
		{
            h1 = hh1;
            h2 = hh2;
		}


	}
}
