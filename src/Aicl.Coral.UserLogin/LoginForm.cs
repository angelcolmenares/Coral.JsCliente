using System;
using System.Html;
using Cayita.Javascript.UI;
using Cayita.Javascript;
using jQueryApi;
using Cayita.Javascript.Plugins;
using Aicl.Coral.Modelos;
using System.Runtime.CompilerServices;

namespace Aicl.Coral.UserLogin
{
	[IgnoreNamespace]
	public class LoginForm{
		
		public LoginForm(Element parent)
		{
			Parent= parent;

		}
						
		public Element Parent {get;private set;}

		public Action<UserLoginResponse,LoginForm> OnLogin {get;set;}
		
		Div Container {get;set;}
		
		public void Close()
		{
			Container.JQuery().Remove();
		}
		
		public void Show()
		{
			Container = Div.CreateContainer(default(Element), container=>{
				Div.CreateRow(container, row=>{
					//
					new Div(row,element=>{
						
						element.ClassName="span4 offset4 well";
						new Legend(element, l=>l.Text("Por favor inicie session"));
						
						new Form(element, fe=>{
							fe.Action= "/api/User/login";

							new TextField(fe, i=>{
								i.SetPlaceHolder("NIT");i.Name="Nit";i.ClassName="span4";
								i.SetRequired();i.SetMinLength(8);
							});

							new TextField(fe, i=>{
								i.SetPlaceHolder("nombre usuario");	i.Name="Nombre";i.ClassName="span4";
								i.SetRequired();i.SetMinLength(4);
							});

							new TextField(fe, i=>{
								i.SetPlaceHolder("clave");	i.Name="Clave";i.ClassName="span4";
								i.SetRequired();i.SetMinLength(4);
								i.Type="password";
							});

							var bt = new SubmitButton(fe, b=>{
								b.JQuery().Text("Iniciar Session");
								b.ClassName="btn btn-info btn-block";
								b.LoadingText("  autenticando....");
							});
							
							var vo = new ValidateOptions()
								.SetSubmitHandler( f=>{
									
									bt.ShowLoadingText();
									
									var req=jQuery.PostRequest<UserLoginResponse>(f.Action, f.Serialize(), cb=>{},"json");
									req.Done(d=>{
										Cayita.Javascript.Firebug.Console.Log(d);
										f.Clear();
										if(OnLogin!=null) OnLogin(d,this);
											
									});
									req.Fail(e=> {
										Cayita.Javascript.Firebug.Console.Log("fail :",req); 
										Div.CreateAlertErrorBefore(fe.Elements[0], req.Status.ToString()+":"+
										                           (req.StatusText.StartsWith("ValidationException")?
										                           "NIT/Usario/clave no validos":
										                           req.StatusText)); 
									});
									req.Always(a=>{
												bt.ResetLoadingText();
									})	;
										
								});
							
							fe.Validate(vo);			
							
						});
						
					});
					
				});
			});
			
			Parent.AppendChild(Container.Element());
		}
		
	}
}

