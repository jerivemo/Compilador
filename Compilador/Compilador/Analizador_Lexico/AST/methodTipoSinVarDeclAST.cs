using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodTipoSinVarDeclAST : methodConTipoAST
	{
        protected formParsAST formpars;

        public methodTipoSinVarDeclAST(Symbol sym, formParsAST form)
		{
            this.ident = sym;
            this.formpars = form;
		}
	}
}
