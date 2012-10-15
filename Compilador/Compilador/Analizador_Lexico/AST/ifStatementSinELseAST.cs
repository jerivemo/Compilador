using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class ifStatementSinELseAST : ifStatementAST
	{
        public ifStatementSinELseAST(conditionAST cnd, statementAST stat)
        {
            this.condition = cnd;
            this.statement1 = stat;
        }
	}
}
