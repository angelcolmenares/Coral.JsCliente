using System;
using System.Html;
using Cayita.Javascript;
using System.Runtime.CompilerServices;
using Aicl.Coral.Modelos;

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
			var store = Factory<Empresa>.GetStore ();
			new  EmpresasGrid (parent, store);
			store.Read ();


		}
	}


}

