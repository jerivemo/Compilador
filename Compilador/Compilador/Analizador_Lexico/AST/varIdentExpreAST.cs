using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varIdentExpreAST : listIdentExprAST
	{
		listIdentExprAST h1;
		listIdentExprAST h2;

		public varIdentExpreAST(listIdentExprAST hh1, listIdentExprAST hh2)
		{
            h1 = hh1;
            h2 = hh2;
		}


	}
}
