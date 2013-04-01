using System;
using System.Reflection;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Aicl.Coral.Cliente.GeneradorModelos
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var assembly = Assembly.LoadFrom (@"/home/angel/Projects/gh/Aicl.Coral/Servidor/src/Aicl.Coral.Modelos/bin/Debug/Aicl.Coral.Modelos.dll");

			var scriptNamespace = "Aicl.Coral.Modelos";
			var dll = "Aicl.Coral.JsCliente.Modelos";

			List<string> files = new List<string>();

			foreach (var t in assembly.GetTypes()) {


				Console.WriteLine("{0}-{1}", t.Name, t.Namespace);
				StringBuilder props = new StringBuilder();

				foreach( var p in t.GetProperties()){

					props.AppendFormat(
						PlantillaPropiedad()+Environment.NewLine,
						p.PropertyType.ToString().Replace("`1","").Replace("[","<").Replace("]",">"),
						p.Name
						);
				}


				using (TextWriter twp = new StreamWriter( t.Name+".cs"))
				{
					twp.Write(string.Format(PlantillaClase(), scriptNamespace, t.Name, props.ToString()));				
					twp.Close();
				}



				files.Add(string.Format("\"{0}\"",t.Name+".cs"));

			}

			using (TextWriter twp = new StreamWriter( "c"))
			{
				twp.Write(string.Format(PlantillaCSharp(), dll, string.Join(@" \"+Environment.NewLine, files.ToArray())) );				
				twp.Close();
			}

			using (TextWriter twp = new StreamWriter( "j"))
			{
				twp.Write(string.Format(PlantillaJs(), dll, string.Join(@" \"+Environment.NewLine, files.ToArray())) );				
				twp.Close();
			}

			Console.WriteLine("this is The End");
		
		}



		static string PlantillaClase()
		{
			return @"using System;
using System.Runtime.CompilerServices;
namespace {0}
{{
	[Serializable]	
	[ScriptNamespace(""{0}"")]
	[PreserveMemberCase]
	public class {1}
	{{
		public {1} ()
		{{
		}}

{2}		
	}}
}}";
		}


		static string PlantillaPropiedad()
		{
			return @"		public {0} {1} {{ get; set; }}";
		}


		static string PlantillaCSharp()
		{
			return @"/opt/mono/bin/dmcs  /noconfig  -nostdlib \
""/out:bin/Debug/{0}.dll"" \
""/define:SALTARELLE"" \
""/debug"" \
""/r:../../lib/mscorlib.dll"" \
/t:library \
{1}
				
cp bin/Debug/{0}.dll ../../lib/
echo ""{0}.dll"" listo
./j";
		}

		static string PlantillaJs()
		{
			return @"/opt/mono/bin/sc \
""/outscript:bin/Debug/{0}.js"" \
""/define:JS"" \
""/debug"" \
""/r:../../lib/mscorlib.dll"" \
""/r:../../lib/Saltarelle.Web.dll"" \
""/r:../../lib/Saltarelle.Linq.dll"" \
""/r:../../lib/Saltarelle.jQuery.dll"" \
/t:library \
{1}
				
cp bin/Debug/{0}.js ../../../Servidor/src/Aicl.Coral.HostWeb/js/
echo ""{0}.js"" listo";
		}



	}
}
// "AssemblyInfo.cs" "Concepto.cs" "Fuente.cs" \
// public Dictionary<string,string> Info{get;set;}