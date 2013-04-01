using System;
using System.Runtime.CompilerServices;
namespace Aicl.Coral.Modelos
{
	[Serializable]	
	[ScriptNamespace("Aicl.Coral.Modelos")]
	[PreserveMemberCase]
	public class Candidato
	{
		public Candidato ()
		{
		}

		public System.Int32 Id { get; set; }
		public System.String Documento { get; set; }
		public System.Int32 IdTipoDocumento { get; set; }
		public System.Int32 IdLugarExpedicion { get; set; }
		public System.String Nombres { get; set; }
		public System.String PrimerApellido { get; set; }
		public System.String SegundoApellido { get; set; }
		public System.Int32 IdEstadoCivil { get; set; }
		public System.DateTime FechaNacimiento { get; set; }
		public System.Int32 IdSanguineo { get; set; }
		public System.String Sexo { get; set; }
		public System.Int32 IdCiudadNacimiento { get; set; }
		public System.String DireccionResidencia { get; set; }
		public System.String Telefono { get; set; }
		public System.String Celular { get; set; }
		public System.String Email { get; set; }
		public System.Int32 IdEps { get; set; }
		public System.Int32 IdAfp { get; set; }
		public System.Int32 IdCesantias { get; set; }
		public System.Int32 IdProfesion { get; set; }
		public System.Int32 IdNivelAcademico { get; set; }
		public System.String LibretaMilitar { get; set; }
		public System.Nullable<System.DateTime> FechaExpedicionDas { get; set; }
		public System.Nullable<System.Int32> IdPuesto { get; set; }
		public System.String TarjetaProfesional { get; set; }
		public System.Nullable<System.Int32> IdUsuarioAprueba { get; set; }
		public System.Int32 IdUsuarioRegistra { get; set; }
		public System.DateTime FechaRegistro { get; set; }
		public System.String PasadoJudicial { get; set; }
		public System.Nullable<System.DateTime> FechaAprobacion { get; set; }
		public System.Int32 IdEstado { get; set; }
		public System.Nullable<System.Int32> IdBarrioResidencia { get; set; }
		public System.String Observacion { get; set; }
		
	}
}