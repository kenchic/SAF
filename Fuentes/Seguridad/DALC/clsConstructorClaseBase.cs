﻿
using System;
using System.Collections.Generic;


namespace Seguridad.DALC
{
    public class clsConstructorClaseBase<T> where T : ClaseBase, new()
    {

        public List<T> CrearObjetos(ref System.Data.DataTable tabla)
        {
            T obj;
            List<T> lista = new List<T>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                obj = new T();
                obj.Id = Convert.ToInt32(fila["ID"]);
                obj.Nombre = fila["NOMBRE"].ToString();
                obj.Activo = Convert.ToBoolean(fila["ACTIVO"]);
                lista.Add(obj);
            }
            return lista;
        }
    }
}
