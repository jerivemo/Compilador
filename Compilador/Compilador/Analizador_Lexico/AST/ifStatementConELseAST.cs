using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class ifStatementConELseAST : ifStatementAST
	{
        protected statementAST statement2;

        public ifStatementConELseAST(conditionAST cnd, statementAST stat1, statementAST stat2)
        {
            this.condition = cnd;
            this.statement1 = stat1;
            this.statement2 = stat2;
        }
	}
}
