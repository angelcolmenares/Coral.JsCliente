using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class ClaseCliente
	{
		public ClaseCliente ()
		{
		}

		public System.Int32 Id { get; set; }
		public System.String Nombre { get; set; }
		public System.String Titulo { get; set; }
		public System.String Icono { get; set; }
		
	}
}