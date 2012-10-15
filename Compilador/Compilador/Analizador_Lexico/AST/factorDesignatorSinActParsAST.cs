using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorDesignatorSinActParsAST : factorDesignatorAST
	{
		public factorDesignatorSinActParsAST(designatorAST d)
		{
		this.designator = d;
		}


	}
}
