using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unIdentExpreConIdentAST : unIdentExpreAST
	{
		 Symbol ident;

	     public  unIdentExpreConIdentAST(Symbol s)
		{
            ident = s;
		}

	}
}
