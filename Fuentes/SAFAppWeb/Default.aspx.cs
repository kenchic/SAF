﻿using System;
using System.Web.Security;
using System.Web.UI.WebControls;
using Seguridad;

namespace SAFAppWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Autenticar DA
        //protected void IniciarSesion_Authenticate(object sender, AuthenticateEventArgs e)
        //{
        //    bool estado;
        //    string nomportal;
        //    string passcredencial;

        //    String adPath = ConfigurationManager.AppSettings["cnxLDAP"]; //Fully-qualified Domain Name
        //    LdapAuthentication adAuth = new LdapAuthentication(adPath);
        //    try
        //    {
        //        if (adAuth.IsAuthenticated(ConfigurationManager.AppSettings["DominioLDAP"], IniciarSesion.UserName, IniciarSesion.Password))
        //        {
        //            //String groups = adAuth.GetGroups();

        //            //Create the ticket, and add the groups.
        //            //bool isCookiePersistent = false;
        //            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(1, IniciarSesion.UserName,
        //                DateTime.Now, DateTime.Now.AddMinutes(60), false, "sclaGroup");

        //            //Encrypt the ticket.
        //            String encryptedTicket = FormsAuthentication.Encrypt(authTicket);

        //            //Create a cookie, and then add the encrypted ticket to the cookie as data.
        //            HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);

        //            //if (true == isCookiePersistent)
        //            //    authCookie.Expires = authTicket.Expiration;

        //            //Add the cookie to the outgoing cookies collection.
        //            Response.Cookies.Add(authCookie);

        //            //You can redirect now.
        //            //Response.Redirect(FormsAuthentication.GetRedirectUrl(IniciarSesion.UserName, false));

        //            CuentaAcceso cuentausuario;
        //            //CuentaAcceso cuentausuario;
        //            cuentausuario = ((SCLA.DAL.OperacionesBD)Session["ejecutorBD"]).autenticarUsuario(IniciarSesion.UserName, "SCLA");

        //            if (cuentausuario == null)
        //            {
        //                e.Authenticated = false;
        //                IniciarSesion.FailureText = "Usuario no encontrado en la aplicación";
        //                return;
        //            }

        //            if (cuentausuario != null && cuentausuario.fechavencimiento < DateTime.Today)
        //            {
        //                IniciarSesion.FailureText = "Cuenta desahabilitada. Por favor contacte al administrador del sistema.";
        //                e.Authenticated = false;
        //                return;
        //            }

        //            e.Authenticated = true;

        //            switch (cuentausuario.perfil.nombre)
        //            {
        //                case "ADMINISTRADOR":
        //                    {
        //                        nomportal = "Administrador";
        //                        passcredencial = "Rats15inDa98";
        //                        break;
        //                    }
        //                default:
        //                    {
        //                        nomportal = "Modificacion";
        //                        passcredencial = "n7OCaF3IdO5";
        //                        break;
        //                    }
        //                /*case "Modificacion":
        //                    {
        //                        nomportal = "Modificacion";
        //                        passcredencial = "n7OCaF3IdO5";
        //                        break;
        //                    }
        //                case "Consulta":
        //                    {
        //                        nomportal = "Consulta";
        //                        passcredencial = "AT7l5us3NoC1";
        //                        break;
        //                    }
        //                default:
        //                    {
        //                        nomportal = "";
        //                        passcredencial = "";
        //                        break;
        //                    }*/
        //            }
        //            ((SCLA.DAL.OperacionesBD)Session["ejecutorBD"]).cuentaacceso = cuentausuario;
        //            //estado = FormsAuthentication.Authenticate(cuentausuario.perfil.nombre, passcredencial);
        //            estado = FormsAuthentication.Authenticate(nomportal, passcredencial);
        //            if (estado)
        //            {
        //                //FormsAuthentication.SetAuthCookie(cuentausuario.perfil.nombre, false);
        //                FormsAuthentication.SetAuthCookie(nomportal, false);
        //                RadioButtonList idiomas = (RadioButtonList)IniciarSesion.FindControl("rblIdiomas");
        //                if (idiomas != null)
        //                {
        //                    if (idiomas.SelectedItem.Value == _IDIOMA_ESPANOL)
        //                    {
        //                        Session["Idioma"] = "es-CO";
        //                    }
        //                    else if (idiomas.SelectedItem.Value == _IDIOMA_INGLES)
        //                    {
        //                        Session["Idioma"] = "en-US";
        //                    }
        //                }
        //                CargarMensajesIdioma(Session["Idioma"].ToString());
        //                if (string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
        //                {
        //                    Response.Redirect(nomportal);
        //                }
        //                else
        //                {
        //                    Response.Redirect(Request.QueryString["ReturnUrl"]);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            IniciarSesion.FailureText = "No logró autenticarse. Verifique el usuario y la clave.";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        IniciarSesion.FailureText = "Error autenticando. " + ex.Message;
        //    }
        //}
        #endregion

        #region Sin Autenticar DA
        protected void InicioSesion_Authenticate(object sender, AuthenticateEventArgs e)
        {
            var ejecutor = (BaseDatos.Comandos)Session["ejecutorBD"];
            var fachadaClaseBase = new Seguridad.DALC.clsFachadaClaseBase(ref ejecutor);
            var usuario = fachadaClaseBase.ConsultarUsuariosAutenticacion(InicioSesion.UserName,InicioSesion.Password);
            if (usuario == null)
            {
                e.Authenticated = false;
                InicioSesion.FailureText = "Nombre de usuario ó contraseña inválida";
                return;
            }
            e.Authenticated = true;
                
            const string nomportal = "sistema";
            const string passcredencial = "kenchic126";
            Session["UsuarioSesion"] = usuario;
#pragma warning disable 612,618
            bool estado = FormsAuthentication.Authenticate(nomportal, passcredencial);
#pragma warning restore 612,618
            if (estado)
            {
                FormsAuthentication.SetAuthCookie(nomportal, false);
                Response.Redirect(string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]) ? nomportal : Request.QueryString["ReturnUrl"]);
            }
        }
        #endregion
    }
}