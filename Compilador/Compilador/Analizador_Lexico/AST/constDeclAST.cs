using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class constDeclAST : declAST
	{
        protected typeAST tipo;
        protected Symbol symb;

		public constDeclAST(typeAST tp, Symbol d)
		{
            this.tipo = tp;
            this.symb = d;
		}
	}
}
