using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varStatementAST : listStatementsAST
	{
		listStatementsAST h1;
		listStatementsAST h2;

		public varStatementAST(listStatementsAST hh1, listStatementsAST hh2)
		{
            h1 = hh1;
            h2 = hh2;
                
		}
	}
}
