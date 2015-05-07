using System.Configuration;

namespace SAFAppWeb.Clases
{
    public class Mensaje
    {
        #region "Miembros Privados"
        private string m_actualizar_bien = "Registro actualizado con éxito.";
        private string m_actualizar_mal = "Error al actualizar el registro.";
        private string m_insertar_bien = "Registro agregado con éxito.";
        private string m_insertar_mal = "Error al agregar el registro.";
        private string m_eliminar_bien = "Registro eliminado con éxito.";
        private string m_eliminar_mal = "Error al eliminar el registro.";
        private string m_texto_total_registros = "Se encontraron #numregistros# registros.";
        private string m_texto_total_registros_particular = "Se encontraron #numregistros# #titulo#.";
        private string m_texto_paginal_actual = "Pagina #pagactual# de #totalpaginas#";
        private string m_enviar_correo_bien;
        private string m_enviar_correo_mal;
        private string m_proceso_terminado_bien = "Proceso terminado satisfactoriamente.";
        private string m_proceso_terminado_mal = "Se produjeron errores al realizar el proceso.";
        private string m_faltan_respuestas = "No se logró calcular el puntaje de la categoría. Asegurese que todas las preguntas tengan selecciona una respuesta.";
        private string m_perfil_fuera_rango = "La evaluación da como resultado un perfil fuera del rango permitido. Por favor verifique la evaluación.";
        private string m_reporte_sin_datos = "El reporte no contiene datos para mostrar.";
        #endregion

        #region "Constantes"
        public const string __NUEVA_LINEA_HTML = "<br/>";
        public const string __NOACCESOCARPETA = "Usted no tiene acceso a éste recurso ó su sesion caducó. Para acceder a éste recurso ingrese su nombre de usuario y contraseña.";
        public const string __PERTENECEDA = " «Su contraseña es la misma de Directorio Activo. Haga uso de ella para ingresar al sistema.»";
        #endregion

        #region "Propiedades"
        public string TextoTotalRegistros
        {
            get { return m_texto_total_registros; }
            set { m_texto_total_registros = value; }
        }
        public string TextoTotalRegistrosParticular
        {
            get { return m_texto_total_registros_particular; }
            set { m_texto_total_registros_particular = value; }
        }
        public string TextoPaginaActual
        {
            get { return m_texto_paginal_actual; }
            set { m_texto_paginal_actual = value; }
        }
        public string ActualizarBien
        {
            get { return m_actualizar_bien; }
            set { m_actualizar_bien = value; }
        }
        public string ActualizarMal
        {
            get { return m_actualizar_mal; }
            set { m_actualizar_mal = value; }
        }
        public string InsertarBien
        {
            get { return m_insertar_bien; }
            set { m_insertar_bien = value; }
        }
        public string InsertarMal
        {
            get { return m_insertar_mal; }
            set { m_insertar_mal = value; }
        }
        public string EliminarBien
        {
            get { return m_eliminar_bien; }
            set { m_eliminar_bien = value; }
        }
        public string EliminarMal
        {
            get { return m_eliminar_mal; }
            set { m_eliminar_mal = value; }
        }
        public string EnviarCorreoBien
        {
            get { return m_enviar_correo_bien; }
            set { m_enviar_correo_bien = value; }
        }
        public string EnviarCorreoMal
        {
            get { return m_enviar_correo_mal; }
            set { m_enviar_correo_mal = value; }
        }
        public string ProcesoTerminadoBien
        {
            get { return m_proceso_terminado_bien; }
            set { m_proceso_terminado_bien = value; }
        }
        public string ProcesoTerminadoMal
        {
            get { return m_proceso_terminado_mal; }
            set { m_proceso_terminado_mal = value; }
        }
        public string FaltanRespuestas
        {
            get { return m_faltan_respuestas; }
            set { m_faltan_respuestas = value; }
        }
        public string PerfilFueraRango
        {
            get { return m_perfil_fuera_rango; }
            set { m_perfil_fuera_rango = value; }
        }
        public string ReporteSinDatos
        {
            get { return m_reporte_sin_datos; }
            set { m_reporte_sin_datos = value; }
        }
        #endregion

        #region "Mensajes Comunes"
        public string totalRegistros(long numregistros)
        {
            return m_texto_total_registros.Replace("#numregistros#", numregistros.ToString());
        }
        public string totalRegistros(long numregistros, string titulo)
        {
            string temp = m_texto_total_registros_particular.Replace("#numregistros#", numregistros.ToString());
            return temp.Replace("#titulo#", titulo);
        }
        public string paginaActual(int pagactual, int totalpaginas)
        {
            string temp = m_texto_paginal_actual.Replace("#pagactual#", pagactual.ToString());
            return temp.Replace("#totalpaginas#", totalpaginas.ToString());
        }
        #endregion

        #region "Cuerpos de Correo Electronico"
        public string obtenerCuerpoCorreoNuevaCuenta(string nombreusuario, string username, string password)
        {
            return "<html><body>Señor " + nombreusuario + ":<br />Se le informa que el Administrador de " + ConfigurationManager.AppSettings["NombreApp"] + " le ha creado una cuenta de acceso " + "para ingresar a la aplicación con los siguientes datos:<br /><br />Usuario: " + username + "<br />Contraseña:" + password + "<br />Por favor no responda este E-Mail.</body></html>";
        }
        public string obtenerCuerpoCorreoModificacionCuenta(string nombreusuario, string username, string password)
        {
            string m_mensaje = null;
            m_mensaje = "<html><body>Señor " + nombreusuario + ":<br />Se le informa que el Administrador de " + ConfigurationManager.AppSettings["NombreApp"] + " ha modificado su cuenta de acceso " + "para ingresar a la aplicación. Los nuevos datos son:<br /><br />Usuario: " + username;
            if ((password != null))
            {
                m_mensaje += "<br />Contraseña:" + password;
            }
            m_mensaje += "<br />Por favor no responda este E-Mail.</body></html>";
            return m_mensaje;
        }
        public string obtenerCuerpoCorreoEnvioARetroalimentacion(string nombreDisciplina, string nombreEmpresa)
        {
            string m_mensaje = null;
            m_mensaje = "<html><body> Sr(a) administrador(a).<br /><br /><br />La autoevaluación de " + nombreDisciplina + " de la empresa " + nombreEmpresa + " ha sido cerrada y está lista para que se inicie la retroalimentación." + "<br /><br /> ";
            m_mensaje += "<br />Por favor no responda este E-Mail.</body></html>";
            return m_mensaje;
        }
        public string obtenerCuerpoCerradoRetroalimentacion(string nombreDisciplina, string nombreEmpresa)
        {
            string m_mensaje = null;
            m_mensaje = "<html><body> Sr(a) administrador(a).<br /><br /><br />La autoevaluación de la empresa " + nombreEmpresa + " ha sido retroalimentada por el personal de " + nombreDisciplina + " ." + "<br /><br /> ";
            m_mensaje += "<br />Por favor no responda este E-Mail.</body></html>";
            return m_mensaje;
        }
        #endregion
    }
}