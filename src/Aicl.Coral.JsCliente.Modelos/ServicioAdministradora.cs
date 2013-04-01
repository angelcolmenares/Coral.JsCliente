using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class ServicioAdministradora
	{
		public ServicioAdministradora ()
		{
		}

		public System.Int32 Id { get; set; }
		public System.String TipoServicio { get; set; }
		
	}
}