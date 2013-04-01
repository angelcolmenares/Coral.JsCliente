using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class UserLoginResponse
	{
		public UserLoginResponse ()
		{
		}

		public Aicl.Coral.Modelos.Empresa Empresa { get; set; }
		public System.Collections.Generic.List<Aicl.Coral.Modelos.Centro> Centros { get; set; }
		public System.Collections.Generic.List<Aicl.Coral.Modelos.SucursalAutorizada> SucursalesAutorizadas { get; set; }
		public System.Collections.Generic.List<System.String> Actividades { get; set; }
		public System.Collections.Generic.List<Aicl.Coral.Modelos.Menu> Menu { get; set; }
		
	}
}