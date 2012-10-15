using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class readStatementAST : statementAST
	{
        protected designatorAST designator;

		public readStatementAST(designatorAST desg)
		{
            this.designator = desg;
		}
	}
}
