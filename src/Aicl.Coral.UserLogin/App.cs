using System;
using jQueryApi;
using System.Html;
using System.Runtime.CompilerServices;
using Aicl.Coral.Modelos;
using Cayita.Javascript.UI;
using Cayita.Javascript;
using System.Collections.Generic;

namespace Aicl.Coral.UserLogin
{
	[IgnoreNamespace]
	public class App
	{
		Div ContenedorItemArea { get; set;}
		Div ContenedorWorkArea { get; set;}
		Element TituloModulo { get; set; }


		Div WorkArea { get; set;}
		Div ItemArea { get; set;}

		List<string>  modules = new List<string>();

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
										ContenedorWorkArea.Hide();
										ContenedorItemArea.Show();
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
													if(modules.Contains(item.Modulo))
													{
														ExecuteModule(item);
													}
													else
													{
														var rq=jQuery.GetScript("modulos/"+item.Modulo+".js");
														rq.Done(cb=>{
															modules.Add(item.Modulo);
															ExecuteModule(item);
														});
														rq.Fail(cb=>{
															Cayita.Javascript.Firebug.Console.Log("fallo al cargar "+ item.Modulo+" :" + rq.StatusText + " " , rq); 
															Bootbox.Error("fallo al cargar "+ item.Modulo+" :" + rq.StatusText);
														});
													}

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
					
					ContenedorItemArea= new Div(row,  div=>{
						div.ClassName="span10";
						div.Append("<style>img {height: 60px;} .shortcuts .shortcut {height: 160px;}</style>");
						ItemArea= new Div(div, i=>{
							i.ClassName="shortcuts";
							var m = Document.CreateElement("h3");
							m.Text("Bienvenido " + lr.DisplayName);
							i.AppendChild(m);
						});
					});

					ContenedorWorkArea = new Div(row, div=>{
						div.ClassName="span10";
						div.Hide();
						new Div(div, i=>{
							i.ClassName="widget stacked";
							new Div(i, h=>{
								h.ClassName="widget-header";
								new Icon(h, icon=>{ 
									icon.ClassName="icon-remove-circle";
									icon.OnClick(evt=>{
										evt.PreventDefault();
										ContenedorWorkArea.Hide();
										WorkArea.Empty();
										ContenedorItemArea.Show();
									}); 

								});
								TituloModulo = Document.CreateElement("h3");
								TituloModulo.Text("Titulo del modulo");
								h.AppendChild(TituloModulo);
							});
							WorkArea= new Div(i, ct=>{
								ct.ClassName="widget-content";
							});
						});
					});


				});
			}).AppendTo(Document.Body);
		}

		[InlineCode("window[{className}]['execute']({parent})")]
		void ExecuteModule(Element parent, string className){}

		void ExecuteModule(Item item)
		{
			ContenedorItemArea.Hide();
			ContenedorWorkArea.Show();
			TituloModulo.InnerHTML=item.Titulo.Replace("<br>","");
			ExecuteModule (WorkArea.Element (), item.Modulo.Replace(".",""));

		}
	}
}

