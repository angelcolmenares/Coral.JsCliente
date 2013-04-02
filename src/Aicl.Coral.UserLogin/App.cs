using System;
using jQueryApi;
using System.Html;
using System.Runtime.CompilerServices;
using Aicl.Coral.Modelos;
using Cayita.Javascript.UI;
using Cayita.Javascript;

namespace Aicl.Coral.UserLogin
{
	[IgnoreNamespace]
	public class App
	{
		Div WorkArea { get; set;}
		Div ItemArea { get; set;}

		public App ()
		{
		}

		public static void Main ()
		{
			jQuery.OnDocumentReady( ()=>{
				var app = new App();
				app.ShowLoginForm();
			});
		}

		void ShowLoginForm()
		{
			var form = new LoginForm(Document.Body);
			form.OnLogin = ShowUserMenu;
			form.Show();
		}


		void ShowUserMenu(UserLoginResponse lr, LoginForm lf)
		{
			lf.Close ();
			Div.CreateContainerFluid(default(Element), fluid=>{
				fluid.Style.PaddingLeft="10px";
				fluid.Style.PaddingRight="0px";
				Div.CreateRowFluid(fluid,  row=>{
					new Div(row,  span=>{
						span.ClassName="span2";
						new SideNavBar(span, list=>{
							foreach(var menu in lr.Menu){
								list.AddItem( (li,anchor)=>{
									anchor.Text(menu.Titulo);
									anchor.OnClick(e=>{
										e.PreventDefault();
										ItemArea.Empty();
										var div = Document.CreateDocumentFragment();
										foreach(var item in menu.Items){
											new Anchor(null, a=>{
												a.ClassName="shortcut";
												new Image(a, img=>{
													img.Src=item.Icono;
													img.ClassName="img-rounded";
												});
												a.OnClick(ev=>{
													ev.PreventDefault();
													Window.Alert(item.Modulo);
												});
												new Span(a, sp=>{
													sp.ClassName="shortcut-label";
													sp.InnerHTML=item.Titulo;
												});
								
											}).AppendTo(div);
										}
										ItemArea.Element().AppendChild(div);
									});
								});
							}
						});
					});
					
					new Div(row,  div=>{
						div.ClassName="span10";
						div.Append("<style>img {height: 60px;} .shortcuts .shortcut {height: 160px;}</style>");
						ItemArea= new Div(div, i=>{
							i.ClassName="shortcuts";
							var m = Document.CreateElement("h3");
							m.Text("Bienvenido " + lr.DisplayName);
							i.AppendChild(m);
						});
					});
				});
			}).AppendTo(Document.Body);
		}

		[InlineCode("MainModule.execute({parent})")]
		void ExecuteModule(Element parent){}


	}
}

