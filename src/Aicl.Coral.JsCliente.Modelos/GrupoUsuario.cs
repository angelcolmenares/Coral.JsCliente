using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class GrupoUsuario
	{
		public GrupoUsuario ()
		{
		}

		public System.String Id { get; set; }
		public System.Int32 IdGrupo { get; set; }
		public System.Int32 IdUsuario { get; set; }
		
	}
}