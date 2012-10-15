using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unTipoIdentAST : listTipoIdentAST
	{
		Symbol ident;
		typeAST tipo;

		public unTipoIdentAST(Symbol s, typeAST t)
		{
            ident = s;
            tipo = t;
		}


	}
}
