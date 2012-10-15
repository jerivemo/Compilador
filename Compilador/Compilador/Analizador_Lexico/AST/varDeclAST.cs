using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class varDeclAST : declAST
	{
		typeAST tipo;
		identListAST identList;

		public varDeclAST(typeAST t, identListAST l)
		{
            tipo = t;
            identList = l;
		}


	}
}
