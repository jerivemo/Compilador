using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorDesignatorConActParsAST : factorDesignatorAST
	{
		actParsAST actPars;

		public factorDesignatorConActParsAST(designatorAST d,actParsAST a)
		{
            this.designator = d;
            actPars = a; 
		}

	}
}
