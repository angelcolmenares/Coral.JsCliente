using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Pais
	{
		public Pais ()
		{
		}

		public System.Int32 Id { get; set; }
		public System.String Nombre { get; set; }
		public System.String Codigo { get; set; }
		
	}
}