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
			//store.Read (opt=>{
			//	opt.OrderByParam="ORDER";
			//	opt.OrderBy="NAME";
			//	opt.DynamicQueryParams.Dynamic="dinamico";
			//	opt.Query<Rq>(new Rq{t1= new DateTime(), t3= new DateTime(2013,3,31), st1="hola mundo"});
			//});

		}
	}

	[PreserveMemberCase]
	[Serializable]
	public class Rq {
		public DateTime t1 { get; set; }
		public DateTime t2 { get; set; }
				public DateTime? t3 { get; set; }
				public DateTime? t4 { get; set; }
				public string st1 { get; set; }
				public string st2 { get; set; }

	}


}

