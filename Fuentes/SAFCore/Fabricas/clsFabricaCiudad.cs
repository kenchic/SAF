///////////////////////////////////////////////////////////
//  clsFabricaCiudad.cs
//  Implementation of the Class clsCiudad
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaCiudad
    {

        public clsFabricaCiudad(){

		}

        ~clsFabricaCiudad()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsCiudad> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsCiudad>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsCiudad();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsCiudad CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsCiudad obj = new clsCiudad();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
