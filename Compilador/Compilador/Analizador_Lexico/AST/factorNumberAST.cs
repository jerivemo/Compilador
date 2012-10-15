using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorNumberAST : factorAST
	{
		Symbol number;

		public factorNumberAST(Symbol n)
		{
            number = n;
		}
	}
}
