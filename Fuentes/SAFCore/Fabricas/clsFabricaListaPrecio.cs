///////////////////////////////////////////////////////////
//  clsFabricaListaPrecio.cs
//  Implementation of the Class clsListaPrecio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaListaPrecio
    {

        public clsFabricaListaPrecio(){

		}

        ~clsFabricaListaPrecio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsListaPrecio> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsListaPrecio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsListaPrecio();
				obj.Id = Convert.ToByte(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsListaPrecio CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsListaPrecio obj = new clsListaPrecio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToByte(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
