///////////////////////////////////////////////////////////
//  clsFabricaConductor.cs
//  Implementation of the Class clsConductor
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaConductor
    {

        public clsFabricaConductor(){

		}

        ~clsFabricaConductor()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsConductor> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsConductor>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsConductor();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Placa = fila["Placa"].ToString();

				lista.Add(obj);
            }
            return lista;
		}

        public clsConductor CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsConductor obj = new clsConductor();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Placa = fila["Placa"].ToString();

            }
            return obj;
		}
    }
}
