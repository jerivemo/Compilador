using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorCharConstAST : factorAST
	{
		Symbol charConst;

		public factorCharConstAST(Symbol c)
		{
        charConst = c;
		}
	}
}
