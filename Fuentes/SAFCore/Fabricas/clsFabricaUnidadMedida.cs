///////////////////////////////////////////////////////////
//  clsFabricaUnidadMedida.cs
//  Implementation of the Class clsUnidadMedida
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaUnidadMedida
    {

        public clsFabricaUnidadMedida(){

		}

        ~clsFabricaUnidadMedida()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsUnidadMedida> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsUnidadMedida>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsUnidadMedida();
				obj.Id = Convert.ToByte(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsUnidadMedida CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsUnidadMedida obj = new clsUnidadMedida();
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
