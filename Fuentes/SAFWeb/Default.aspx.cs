﻿using System;
using System.Collections.Generic;
using System.Linq;



namespace SAFWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] filesindirectory = System.IO.Directory.GetFiles(Server.MapPath("~/img/fondos"));
            Random random = new Random();
            int randomNumber = random.Next(1, filesindirectory.Length);
            string url = String.Format("~/img/fondos/{0}", randomNumber + ".jpg");
            body.Style["background-image"] = Page.ResolveUrl(url);
            body.Style["background-size"] = "cover";
        }
    }
}