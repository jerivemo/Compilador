using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class conditionAST : AST
	{
        protected listCondTermAST listCondTerm;

		public conditionAST(listCondTermAST lCndTerm)
		{
            this.listCondTerm = lCndTerm;
		}
	}
}
