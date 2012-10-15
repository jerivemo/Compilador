using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varsdeclAST : declsAST
	{
		declsAST h1;
		declsAST h2;

		public varsdeclAST(declsAST d1, declsAST d2)
		{
            h1 = d1;
            h2 = d2;
		}



	}
}
