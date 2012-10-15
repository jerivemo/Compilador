using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class designatorConIdentExprAST : designatorAST
	{
		protected listIdentExprAST listIdentExpr;
        Symbol simbol;
		public designatorConIdentExprAST(Symbol s,listIdentExprAST l)
		{
            this.listIdentExpr = l;
            simbol=s;
		}


	}
}
