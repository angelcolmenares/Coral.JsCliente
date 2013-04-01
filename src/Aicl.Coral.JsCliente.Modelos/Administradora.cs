using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Administradora
	{
		public Administradora ()
		{
		}

		public System.Int32 Id { get; set; }
		public System.String Nit { get; set; }
		public System.String Dv { get; set; }
		public System.String Nombre { get; set; }
		public System.Int32 IdServicio { get; set; }
		public System.String Codigo { get; set; }
		public System.String Direccion { get; set; }
		public System.String Telefono { get; set; }
		
	}
}