using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class AdminLogin
	{
		public AdminLogin ()
		{
		}

		public System.String Nombre { get; set; }
		public System.String Clave { get; set; }
		
	}
}