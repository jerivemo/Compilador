using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varMulopTermAST : listMulopFactorAST
	{
		listMulopFactorAST h1;
		listMulopFactorAST h2;

		public varMulopTermAST(listMulopFactorAST hh1, listMulopFactorAST hh2)
		{
            h1 = hh1;
            h2 = hh2;
		}

	}
}
