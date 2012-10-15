using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class forStatementConCondFuntAST : forStatementAST
	{
		exprAST funtion;
		conditionAST condition;

		public forStatementConCondFuntAST(exprAST d, conditionAST c, exprAST f, statementAST s)
		{
            this.decl = d;
            this.condition = c;
            this.funtion = f;
            this.statement = s;
  		}

	}
}
