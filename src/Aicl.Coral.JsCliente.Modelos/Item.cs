using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Item
	{
		public Item ()
		{
		}

		public System.String Titulo { get; set; }
		public System.String Modulo { get; set; }
		public System.String Icono { get; set; }
		
	}
}