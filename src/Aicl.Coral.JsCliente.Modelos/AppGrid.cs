using System;
using System.Runtime.CompilerServices;
using Cayita.Javascript.UI;
using System.Html;
using System.Collections.Generic;
using Cayita.Javascript.Data;

namespace Aicl.Coral.Modelos
{
	[ScriptNamespace("Aicl.Coral.Modelos")]
	public class AppGrid<T>:HtmlGrid<T> where T: new()
	{
		AppStore<T> store_;

		public AppGrid (Element parent, AppStore<T> store,List<TableColumn<T>> columns)
			:base(parent,  store, columns)
		{
			SetReadRequestMessage (m => {
				m.Message= string.Format("Leyendo : '{0}'", typeof(T).Name);
			});

			store_ = store;

			store_.OnStoreError += (st, err) => {

				switch(err.Action){
				case StoreErrorAction.Read:
					Cayita.Javascript.Firebug.Console.Log("Error al leer", err.Request);
					break;
				default:
					Cayita.Javascript.Firebug.Console.Log("Error ", err.Action, err.Request);
					break;
				}
			};

			if (store_.Count > 0)
				Render ();
		}
		
		public new  AppStore<T> GetStore(){
			return store_;
		}

	}
}

