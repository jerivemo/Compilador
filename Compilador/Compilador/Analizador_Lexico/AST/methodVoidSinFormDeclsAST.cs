using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodVoidSinFormDeclsAST : methodConVoidAST
	{
        public methodVoidSinFormDeclsAST(Symbol sym)
		{
            this.ident = sym;
		}
	}
}
