using BaseDatos;
using SAFcore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SAFWeb.SAFcore.Controles
{
    public partial class ctrElementoForm : System.Web.UI.UserControl
    {
        #region Propiedades
        public long IdElemento
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
            if (long.TryParse(Request["IdElemento"], out valor))
                IdElemento = valor;
        }

        private void obtenerDatos()
        {
            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            SentenciaSQL sql = new SentenciaSQL();
            sql.FiltroBD.Add(new FiltroBD(clsElemento.Campos.id, IdElemento, FiltroBD.OperadorLogico.igual));
            sql.OrdenBD.Add(clsElemento.Campos.nombre);

            DataTable Elemento = fachadaCore.consultarDatosElemento(sql);
            flDatos.DataSource = Elemento;
        }
        private void insertarDatos()
        {
            clsElemento Elemento = new clsElemento();
            if (cbidGruposElemento.Value != null)
Elemento.idGruposElemento = (Byte)cbidGruposElemento.Value;
if (cbidUnidadMedida.Value != null)
Elemento.idUnidadMedida = (Byte)cbidUnidadMedida.Value;
Elemento.Referencia = txtReferencia.Text;
Elemento.Nombre = txtNombre.Text;
Elemento.Mt2 = txtMt2.Text;
Elemento.Peso = txtPeso.Text;
Elemento.Rotacion = ckRotacion.Checked ? true : false;
Elemento.Activo = ckActivo.Checked ? true : false;

            var ejecutor = (Comandos)Session["ejecutorBDSAFcore"];
            var fachadaCore = new clsFachadaSAFcore(ref ejecutor);

            int resultado = 0;
            if (IdElemento == 0)
            {
                resultado = fachadaCore.insertarElemento(Elemento);                
                lbId.Text = resultado.ToString();
            }
            else
            {
                SentenciaSQL sql = new SentenciaSQL();
                sql.FiltroBD.Add(new FiltroBD(clsElemento.Campos.id, IdElemento, FiltroBD.OperadorLogico.igual));
                resultado = fachadaCore.editarElemento(Elemento, sql);
            }
        }
        #endregion
    }
}