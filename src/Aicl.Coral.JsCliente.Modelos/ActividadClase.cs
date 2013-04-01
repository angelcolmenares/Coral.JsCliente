using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class ActividadClase
	{
		public ActividadClase ()
		{
		}

		public System.String Id { get; set; }
		public System.Int32 IdActividad { get; set; }
		public System.Int32 IdClase { get; set; }
		
	}
}