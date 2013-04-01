using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class SucursalAutorizada
	{
		public SucursalAutorizada ()
		{
		}

		public Aicl.Coral.Modelos.Sucursal Sucursal { get; set; }
		public System.Collections.Generic.List<System.Int32> IdCentros { get; set; }
		
	}
}