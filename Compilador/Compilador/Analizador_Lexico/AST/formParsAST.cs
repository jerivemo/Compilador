using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public class formParsAST : AST
	{
	    listTipoIdentAST tipoIdent;

		public formParsAST(listTipoIdentAST l)
		{
            tipoIdent = l;
		}
	}
}
