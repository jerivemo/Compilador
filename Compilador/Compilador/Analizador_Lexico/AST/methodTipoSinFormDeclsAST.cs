using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodTipoSinFormDeclsAST : methodConTipoAST
	{
        public methodTipoSinFormDeclsAST(Symbol sym)
		{
            this.ident = sym;
		}
	}
}
