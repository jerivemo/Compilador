using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class expreSoloTermAST : exprAST
	{
        termAST term;
        public expreSoloTermAST(termAST t)
		{
			term=t;
		}


	}
}
