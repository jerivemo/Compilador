using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodVoidSinFormParsAST : methodConVoidAST
	{
        protected declsAST decl;

        public methodVoidSinFormParsAST(declsAST dec, Symbol sym)
		{
            this.decl = dec;
            this.ident = sym;
		}
    }
}
