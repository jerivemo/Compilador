using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class termConMulopFactorAST : termAST
	{
		listMulopFactorAST listMuloppFactor;

		public termConMulopFactorAST(factorAST f,listMulopFactorAST l )
		{
            factor = f;
            listMuloppFactor = l;           
		}

	}
}
