using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class methodVoidSinVarDeclAST : methodConVoidAST
	{
        protected formParsAST formpars;

		public methodVoidSinVarDeclAST(formParsAST form, Symbol sym)
		{
            this.formpars = form;
            this.ident = sym;
		}
        
		}
	}

