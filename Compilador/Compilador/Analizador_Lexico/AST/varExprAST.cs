using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varExprAST : listExprAST
	{
		listExprAST h1;
		listExprAST h2;

		public varExprAST(listExprAST hh1, listExprAST hh2)
		{
            h1 = hh1;
            h2 = hh2;
		}


	}
}
