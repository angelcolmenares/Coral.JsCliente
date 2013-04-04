using System;
using System.Html;
using Cayita.Javascript;
using System.Runtime.CompilerServices;

namespace Aicl.Coral.Empresas
{
	[IgnoreNamespace]
	[ScriptName("AdministracionEmpresas")]
	public class Controlador
	{
		public Controlador ()
		{
		}

		public static void Execute(Element parent)
		{
			//Document.CreateElement ("h2").Text ("Default styles").AppendTo (parent);
			var eg= new  EmpresasGrid (parent);


		}
	}


}

