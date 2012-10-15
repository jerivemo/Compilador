using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class whileStatementAST : statementAST
	{
		conditionAST condition;
		statementAST statement;

		public whileStatementAST(conditionAST c, statementAST s)
		{
            condition = c;
            statement = s;
		}
	}
}
