using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class forStatementConConditionAST : forStatementAST
	{
		conditionAST condition;

        public forStatementConConditionAST(exprAST d, conditionAST c, statementAST s)
		{
            this.decl = d;
            this.condition = c;
            this.statement = s;
		}


	}
}
