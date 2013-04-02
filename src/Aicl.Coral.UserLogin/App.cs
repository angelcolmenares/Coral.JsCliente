using System;
using jQueryApi;
using System.Html;
using System.Runtime.CompilerServices;

namespace Aicl.Coral.UserLogin
{
	[IgnoreNamespace]
	public class App
	{
		public App ()
		{
		}

		public static void Main ()
		{
			jQuery.OnDocumentReady( ()=>{
				
				var app = new App();
				//app.ShowTopNavBar();
				app.ShowLoginForm();
				
			});
		}

		void ShowLoginForm()
		{
			var form = new LoginForm(Document.Body);
			
			//form.OnLogin=OnLogin;
			form.Show();
			
		}
	}
}

