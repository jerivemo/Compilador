using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class designatorStatementAsignacionAST : designatorStatementAST
	{
		protected exprAST expre;

		public designatorStatementAsignacionAST(exprAST e)
		{
            this.expre = e;
		}


	}
}
