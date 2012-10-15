using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class programConTodoAST : programAST
	{
        protected declsAST declarations;

		public programConTodoAST(Symbol s, declsAST d)
		{
            ident = s;
            declarations = d;
            
		}
	}
}
