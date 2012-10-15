using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class condTermAST : AST
	{
        protected listCondFactAST listCondFact;

		public condTermAST(listCondFactAST lCndFact)
		{
            this.listCondFact = lCndFact;
		}
	}
}
