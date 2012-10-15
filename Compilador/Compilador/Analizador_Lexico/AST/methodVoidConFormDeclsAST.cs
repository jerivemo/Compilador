using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodVoidConFormDeclsAST : methodConVoidAST
	{
        protected declsAST decl;
        protected formParsAST formpars;

		public methodVoidConFormDeclsAST(declsAST dec, formParsAST form, Symbol sym)
		{
            this.decl = dec;
            this.formpars = form;
            this.ident = sym;
		}
	}
}
