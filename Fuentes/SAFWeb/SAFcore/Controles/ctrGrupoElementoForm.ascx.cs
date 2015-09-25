using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrGrupoElementoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdGrupoElemento
        {
            get
            {
                long valor = 0;
                long.TryParse(lbId.Text, out valor);
                return valor;
            }

            set
            {
                lbId.Text = value.ToString();
            }
        }
        #endregion

        #region eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                obtenerQueryString();
                obtenerDatos();
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            insertarDatos();
        }
        #endregion

        #region Metodos
        private void obtenerQueryString()
        {
            long valor = 0;
            if (long.TryParse(Request["IdGrupoElemento"], out valor))
                IdGrupoElemento = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsGrupoElemento.Campos.id, IdGrupoElemento, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsGrupoElemento.Campos.nombre);

            DataTable GrupoElemento = fachadaCore.consultarDatosGrupoElemento(sql);
            flDatos.DataSource = GrupoElemento;
        }
        private void insertarDatos()
        {
            clsGrupoElemento GrupoElemento = new clsGrupoElemento();
            GrupoElemento.Nombre = txtNombre.Text;
            GrupoElemento.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdGrupoElemento == 0)
            {
                resultado = fachadaCore.insertarGrupoElemento(GrupoElemento);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsGrupoElemento.Campos.id, IdGrupoElemento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarGrupoElemento(GrupoElemento, sql);
            }
        }
        #endregion
    }
}