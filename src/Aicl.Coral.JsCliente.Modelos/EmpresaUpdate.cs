using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class EmpresaUpdate
	{
		public EmpresaUpdate ()
		{
		}

		public System.Int32 Id { get; set; }
		public System.String Codigo { get; set; }
		public System.String Nombre { get; set; }
		public System.String Direccion { get; set; }
		public System.String Nit { get; set; }
		public System.String Dv { get; set; }
		public System.String Telefono { get; set; }
		public System.String Email { get; set; }
		public System.String RepresentanteLegal { get; set; }
		public System.Int32 IdMunicipio { get; set; }
		public System.Int32 IdAdministradora { get; set; }
		public System.String FormaPresentacionSS { get; set; }
		public System.Int32 IdTipoDocumento { get; set; }
		public System.Int32 TipoAportanteSS { get; set; }
		public System.Boolean UsarXmpp { get; set; }
		public System.String ConexionContabilidad { get; set; }
		public System.Nullable<System.Int32> IdRepresentanteLegal { get; set; }
		public System.String CargoFirma { get; set; }
		
	}
}