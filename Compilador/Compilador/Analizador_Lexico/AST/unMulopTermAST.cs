using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unMulopTermAST : listMulopFactorAST
	{
		mulopAST mulop;
		factorAST factor;

		public unMulopTermAST(mulopAST m, factorAST f)
		{
            mulop = m;
            factor = f;
		}


	}
}
