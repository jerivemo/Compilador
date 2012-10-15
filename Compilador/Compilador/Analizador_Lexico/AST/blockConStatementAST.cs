using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class blockConStatementAST : blockAST
	{
		protected listStatementsAST listStatetment;

        public blockConStatementAST(listStatementsAST l)
		{
            this.listStatetment = l;
		}
	}
}
