using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
namespace SAFAppWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Datos.Comandos ejecutor = new Datos.Comandos("Data Source=localhost;Initial Catalog=SAF; User ID=saf; Password=K9/saf$126", "System.Data.SqlClient", "pDATOS");
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