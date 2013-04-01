using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Municipio
	{
		public Municipio ()
		{
		}

		public System.Int32 Id { get; set; }
		public System.String Codigo { get; set; }
		public System.String Nombre { get; set; }
		public System.Int32 IDDepartamento { get; set; }
		public System.String CodigoAlternativo { get; set; }
		
	}
}