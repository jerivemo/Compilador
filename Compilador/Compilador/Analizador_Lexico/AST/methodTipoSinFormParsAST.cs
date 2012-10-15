using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodTipoSinFormParsAST : methodConTipoAST
	{
        protected declsAST decl;

        public methodTipoSinFormParsAST(Symbol sym, declsAST dec)
		{
            this.ident = sym;
            this.decl = dec;
		}
	}
}
