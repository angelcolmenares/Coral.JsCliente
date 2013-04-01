using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class UsuarioCentroSucursal
	{
		public UsuarioCentroSucursal ()
		{
		}

		public System.String Id { get; set; }
		public System.Int32 IdEmpresa { get; set; }
		public System.Int32 IdSucursal { get; set; }
		public System.Int32 IdCentro { get; set; }
		public System.Int32 IdUsuario { get; set; }
		
	}
}