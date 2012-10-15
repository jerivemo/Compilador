using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorBoolAST : factorAST
	{
		Symbol booleano;

		public factorBoolAST(Symbol s)
		{
            booleano = s;
		}

	}
}
