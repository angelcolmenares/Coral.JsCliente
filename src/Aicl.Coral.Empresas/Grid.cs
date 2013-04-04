using System;
using System.Runtime.CompilerServices;
using Cayita.Javascript.UI;
using Aicl.Coral.Modelos;
using System.Html;
using System.Collections.Generic;
using Cayita.Javascript;

namespace Aicl.Coral.Empresas
{
	[IgnoreNamespace]
	[ScriptName("EmpresasGrid")]
	public class EmpresasGrid:HtmlGrid<Empresa>
	{
		AppStore<Empresa> store;

		public  EmpresasGrid (Element parent)
			:base(null, Factory<Empresa>.GetStore(), DefineColumns())
		{
			base.GetStore ().Read ();
			AppendTo(parent);
			store = Factory<Empresa>.GetStore ();

		}

		public new  AppStore<Empresa> GetStore(){
			return store;
		}

		static List<TableColumn<Empresa>> DefineColumns()
		{
			var columns = new List<TableColumn<Empresa>> ();

			columns.Add(new TableColumn<Empresa>(){
				Header= new TableCell(c=> c.Text("NIT")).Element(),
				Value= (f)=>{
					return new TableCell( c=>{
						c.SetValue(f.Nit);
					}).Element();
				}
			});

			columns.Add(new TableColumn<Empresa>(){
				Header= new TableCell(c=> c.Text("DV")).Element(),
				Value= (f)=>{
					return new TableCell( c=>{
						c.SetValue(f.Dv);
					}).Element();
				}
			});

			columns.Add(new TableColumn<Empresa>(){
				Header= new TableCell(c=> c.Text("Razon Social")).Element(),
				Value= (f)=>{
					return new TableCell( c=>{
						c.SetValue(f.Nombre);
					}).Element();
				}
			});

			columns.Add(new TableColumn<Empresa>(){
				Header= new TableCell(c=> c.Text("Representante")).Element(),
				Value= (f)=>{
					return new TableCell( c=>{
						c.SetValue(f.RepresentanteLegal);
					}).Element();
				}
			});

			columns.Add(new TableColumn<Empresa>(){
				Header= new TableCell(c=> c.Text("Telefono")).Element(),
				Value= (f)=>{
					return new TableCell( c=>{
						c.SetValue(f.Telefono);
					}).Element();
				}
			});

			return columns;
		}

	}
}

