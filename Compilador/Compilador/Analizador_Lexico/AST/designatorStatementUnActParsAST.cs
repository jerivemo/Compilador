using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class designatorStatementUnActParsAST : designatorStatementActParsAST
	{
		protected actParsAST actPars;

		public designatorStatementUnActParsAST(actParsAST a)
		{
            this.actPars = a;
		}


	}
}
