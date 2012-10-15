using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class actParsAST : AST
	{
		protected listExprAST listExpr;

		public actParsAST(listExprAST l)
		{
            this.listExpr = l;
 		}
         
       }
}
