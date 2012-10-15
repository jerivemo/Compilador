using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class termSinMulopFactorAST : termAST
	{
		public termSinMulopFactorAST(factorAST f)
		{
            this.factor = f;
        }

	}
}
