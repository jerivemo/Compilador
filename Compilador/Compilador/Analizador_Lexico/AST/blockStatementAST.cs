using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class blockStatementAST : statementAST
	{
		protected listStatementsAST listStatements;

		public blockStatementAST(listStatementsAST l)
		{
            this.listStatements = l;
		}
	}
}
