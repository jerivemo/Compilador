using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public abstract class methodDeclAST : declAST
	{
        protected Symbol ident;
	}
}
