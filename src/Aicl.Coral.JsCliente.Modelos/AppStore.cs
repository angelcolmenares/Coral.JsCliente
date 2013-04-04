using System;
using Cayita.Javascript.Data;
using System.Runtime.CompilerServices;

namespace Aicl.Coral.Modelos
{

	[ScriptNamespace("Aicl.Coral.Modelos")]
	public class AppStore<T>: Store<T> where T: new()
	{
		public AppStore ():base()
		{
		}
	}

	[ScriptNamespace("Aicl.Coral.Modelos")]
	public static class Factory<T> where T: new()
	{
		static AppStore<T> store_;
		public static AppStore<T> GetStore()
		{
			return store_ ?? (store_= new AppStore<T>() ); 
		}
	}
}

