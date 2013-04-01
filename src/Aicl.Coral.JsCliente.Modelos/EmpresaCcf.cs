using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class EmpresaCcf
	{
		public EmpresaCcf ()
		{
		}

		public System.String Id { get; set; }
		public System.Int32 IdEmpresa { get; set; }
		public System.Int32 IdDepartamento { get; set; }
		public System.Int32 IdAdministradora { get; set; }
		
	}
}