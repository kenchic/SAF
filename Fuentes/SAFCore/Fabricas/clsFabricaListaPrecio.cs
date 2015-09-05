///////////////////////////////////////////////////////////
//  clsFabricaListaPrecio.cs
//  Implementation of the Class clsListaPrecio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
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
		    var lista = new List<clsListaPrecio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsListaPrecio();
                obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsListaPrecio CrearObjeto(System.Data.DataTable tabla){
		    clsListaPrecio obj = new clsListaPrecio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
