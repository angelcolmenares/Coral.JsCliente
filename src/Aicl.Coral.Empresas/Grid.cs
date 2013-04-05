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
		AppStore<Empresa> store_;

		public  EmpresasGrid (Element parent, AppStore<Empresa> store)
			:base(parent,  store, DefineColumns())
		{
			store_ = store;
		}

		public new  AppStore<Empresa> GetStore(){
			return store_;
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

