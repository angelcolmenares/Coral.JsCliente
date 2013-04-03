using System;
using System.Html;
using Cayita.Javascript;
using System.Runtime.CompilerServices;

namespace Administracion
{
	[IgnoreNamespace]
	[ScriptName("AdministracionEmpresas")]
	public class Empresas
	{
		public Empresas ()
		{
		}

		public static void Execute(Element parent)
		{
			Document.CreateElement ("h2").Text ("Default styles").AppendTo (parent);
		}
	}


}

