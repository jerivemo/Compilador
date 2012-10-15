using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class classConVarDeclAST : classDeclAST
	{
		protected declsAST decl;

		public classConVarDeclAST(declsAST d, Symbol s)
		{
            this.decl = d;
            this.ident = s;
		}
	}
}
