using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Centro
	{
		public Centro ()
		{
		}

		public System.Int32 IdEmpresa { get; set; }
		public System.Int32 Id { get; set; }
		public System.String Codigo { get; set; }
		public System.String Nombre { get; set; }
		public System.DateTime FechaInicio { get; set; }
		public System.Nullable<System.DateTime> FechaTerminacion { get; set; }
		public System.String NumeroContrato { get; set; }
		public System.Nullable<System.Int32> IdTercero { get; set; }
		
	}
}