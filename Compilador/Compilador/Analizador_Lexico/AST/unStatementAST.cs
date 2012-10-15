using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class unStatementAST : listStatementsAST
	{
		statementAST statement;

		public unStatementAST(statementAST s)
		{
            statement = s;
		}


	}
}
