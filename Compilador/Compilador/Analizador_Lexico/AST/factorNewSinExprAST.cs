using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class factorNewSinExprAST : factorNewAST
	{
        public factorNewSinExprAST(Symbol s) 
        {
            this.ident = s;
        }
	}
}
