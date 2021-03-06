﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BaseDatos;
using SAFseg;

namespace SAFWeb.Sistema.Controles
{
    public partial class frmEncabezado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var ejecutor = (Comandos)Session["ejecutorBDSAFseg"];
                var fachadaSeg = new clsFachadaSAFSegAdicional(ref ejecutor);
                var rol = (clsRol)Session["UsuarioRol"];

                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsMenuRol.Campos.idrol, rol.Id, FiltroBD.OperadorLogico.igual));
                sql.FiltroBD.Add(new FiltroBD(clsMenu.Campos.idmenunivel1, 0, FiltroBD.OperadorLogico.igual));
                sql.OrdenBD.Add(clsMenu.Campos.orden);
                List<clsMenu> menu = fachadaSeg.consultarListaMenuRol(sql);
                if (menu != null)
                {
                    foreach (var item in menu)
                        Menu.Items.Add(item.Nombre, "ID" + item.Id, "", item.Url);
                }
            }
        }
    }
}