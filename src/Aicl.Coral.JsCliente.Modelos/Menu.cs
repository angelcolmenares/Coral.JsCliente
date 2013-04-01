using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Menu
	{
		public Menu ()
		{
		}

		public System.String Titulo { get; set; }
		public System.Collections.Generic.List<Aicl.Coral.Modelos.Item> Items { get; set; }
		
	}
}