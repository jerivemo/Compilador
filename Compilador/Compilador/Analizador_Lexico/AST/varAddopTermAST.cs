using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varAddopTermAST : listAddopTermAST
	{
		listAddopTermAST h1;
		listAddopTermAST h2;

		public varAddopTermAST(listAddopTermAST hh1, listAddopTermAST hh2)
		{
            h1 = hh1;
            h1 = hh2;
		}


	}
}
