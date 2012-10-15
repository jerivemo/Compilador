using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varTipoIdentAST : listTipoIdentAST
	{
		listTipoIdentAST h1;
		listTipoIdentAST h2;

		public varTipoIdentAST(listTipoIdentAST hh1, listTipoIdentAST hh2)
		{
            h1 = hh1;
            h2 = hh2;
		}


	}
}
