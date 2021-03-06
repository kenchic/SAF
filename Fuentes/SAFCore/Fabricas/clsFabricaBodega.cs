///////////////////////////////////////////////////////////
//  clsFabricaBodega.cs
//  Implementation of the Class clsBodega
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaBodega
    {

        public clsFabricaBodega(){

		}

        ~clsFabricaBodega()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsBodega> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsBodega>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsBodega();
				obj.Id = Convert.ToByte(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsBodega CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsBodega obj = new clsBodega();
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
