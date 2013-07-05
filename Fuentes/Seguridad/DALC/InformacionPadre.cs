namespace Cfo.DALC
{
    public class InformacionPadre
    {

        #region "Miembros"
        private string m_columnaid;
        private string m_columnanombre;
        #endregion
        private string m_nombrepropiedad;


        public InformacionPadre()
        {
        }
        public InformacionPadre(string nombrePropiedad, string columnaId, string columnaNombre)
        {
            m_nombrepropiedad = nombrePropiedad;
            m_columnaid = columnaId;
            m_columnanombre = columnaNombre;
        }

        #region "Propiedades"
        public string ColumnaId
        {
            get { return m_columnaid; }
            set { m_columnaid = value; }
        }
        public string ColumnaNombre
        {
            get { return m_columnanombre; }
            set { m_columnanombre = value; }
        }
        public string NombrePropiedad
        {
            get { return m_nombrepropiedad; }
            set { m_nombrepropiedad = value; }
        }
        #endregion

    }
    // InformacionPadre

}
