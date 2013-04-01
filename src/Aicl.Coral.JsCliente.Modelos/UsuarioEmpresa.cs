using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class UsuarioEmpresa
	{
		public UsuarioEmpresa ()
		{
		}

		public System.String Id { get; set; }
		public System.Int32 IdEmpresa { get; set; }
		public System.Int32 IdUsuario { get; set; }
		public System.Boolean RequiereSucursal { get; set; }
		
	}
}