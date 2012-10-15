using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodTipoConFormDeclsAST : methodConTipoAST
	{
        protected declsAST decl;
        protected formParsAST formpars;

		public methodTipoConFormDeclsAST(Symbol sym,  declsAST dec, formParsAST form)
		{
            this.ident = sym;
            this.decl = dec;
            this.formpars = form;
		}
	}
}
