using System;
using System.Collections.Generic;
using System.Text;
using Runtime;

namespace Compilador.Analizador_Lexico.AST
{
	public abstract class AST
	{
	public abstract Object visit(Visitor v, Object arg);
	}
}
