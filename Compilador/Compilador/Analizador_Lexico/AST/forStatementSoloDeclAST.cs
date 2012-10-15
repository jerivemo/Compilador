using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class forStatementSoloDeclAST : forStatementAST
	{
        public forStatementSoloDeclAST(exprAST d,statementAST s)
		{
            this.decl = d;
            this.statement = s;
		}

	}
}
