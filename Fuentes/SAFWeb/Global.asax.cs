using System;
using System.Collections.Generic;
using System.Linq;
using BaseDatos;
using System.Configuration;
using System.Web;


namespace SAFWeb
{
    public class Global_asax : System.Web.HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            DevExpress.Web.ASPxWebControl.CallbackError += new EventHandler(Application_Error);            
        }

        void Application_End(object sender, EventArgs e)
        {
            // Code that runs on application shutdown
        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
            var ejecutor = new Comandos(ConfigurationManager.ConnectionStrings["SAF"].ConnectionString, "System.Data.SqlClient");
            Session["ejecutorBDSAF"] = ejecutor;
            ejecutor = new Comandos(ConfigurationManager.ConnectionStrings["SAFseg"].ConnectionString, "System.Data.SqlClient");
            Session["ejecutorBDSAFseg"] = ejecutor;
        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
        }
    }
}