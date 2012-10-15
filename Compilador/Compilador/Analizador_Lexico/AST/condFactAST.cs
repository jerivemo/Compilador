using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class condFactAST : AST
	{
		protected exprAST expr1;
        protected relopAST relop;
        protected exprAST expr2;

        public condFactAST(exprAST exp1, relopAST rlp, exprAST exp2)
		{
            this.expr1 = exp1;
            this.relop = rlp;
            this.expr2 = exp2;
		}
	}
}
