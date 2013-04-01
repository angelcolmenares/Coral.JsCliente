using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Sucursal
	{
		public Sucursal ()
		{
		}

		public System.Int32 IdEmpresa { get; set; }
		public System.Int32 Id { get; set; }
		public System.String Codigo { get; set; }
		public System.Int32 IdMunicipio { get; set; }
		public System.String Direccion { get; set; }
		public System.String Telefono { get; set; }
		public System.String Nombre { get; set; }
		public System.String Gerente { get; set; }
		public System.Nullable<System.Int32> IdRepresentante { get; set; }
		public System.String CargoFirma { get; set; }
		
	}
}