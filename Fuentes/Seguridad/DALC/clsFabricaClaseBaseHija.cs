using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using Seguridad;
using Seguridad.DALC;


namespace Cfo.DALC
{
    public class clsFabricaClaseBaseHija<T, P> : IFabricaEntidad<T>
        where T : ClaseBase, new()
        where P : ClaseBase, new()
    {


        private InformacionPadre m_InformacionPadre;
        public clsFabricaClaseBaseHija(InformacionPadre informacionPadre)
        {
            m_InformacionPadre = informacionPadre;
        }

        /// 
        /// <param name="tabla"></param>
        public List<T> CrearObjetos(ref DataTable tabla)
        {
            T obj;
            List<T> lista = new List<T>();
            foreach (DataRow fila in tabla.Rows)
            {
                obj = new T();
                obj.Id = Convert.ToInt32(fila["ID"]);
                obj.Nombre = fila["NOMBRE"].ToString();
                obj.Activo = Convert.ToBoolean(fila["ACTIVO"]);
                try
                {
                    if (((m_InformacionPadre != null) && !(string.IsNullOrEmpty(m_InformacionPadre.NombrePropiedad))))
                    {
                        P padre;
                        Type tipoPadre = obj.GetType();
                        PropertyInfo propiedad = tipoPadre.GetProperty(m_InformacionPadre.NombrePropiedad);
                        padre = new P();
                        if ((!(string.IsNullOrEmpty(m_InformacionPadre.ColumnaId))))
                        {
                            padre.Id = Convert.ToInt32(fila[m_InformacionPadre.ColumnaId]);
                        }
                        if ((!(string.IsNullOrEmpty(m_InformacionPadre.ColumnaNombre))))
                        {
                            padre.Nombre = fila[m_InformacionPadre.ColumnaNombre].ToString();
                        }
                        propiedad.SetValue(obj, padre, null);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear la instancia padre del objecto. " + ex.Message);
                }
                lista.Add(obj);
            }
            return lista;
        }


    }
    // FabricaTablasBasicasDescripcionHijas

}
