using System;
namespace SAFAppWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            var ejecutor = new BaseDatos.Comandos("Data Source=CRONOS;Initial Catalog=SAF; User ID=saf; Password=Admin123*", "System.Data.SqlClient", "pDATOS");
            Session["mensajes"] = new Clases.Mensaje();
            Session["ejecutorBD"] = ejecutor;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}