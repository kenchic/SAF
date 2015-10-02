///////////////////////////////////////////////////////////
//  clsFabricaVenta.cs
//  Implementation of the Class clsVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaVenta
    {

        public clsFabricaVenta(){

		}

        ~clsFabricaVenta()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsVenta> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsVenta>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsVenta();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idRemision = Convert.ToInt32(fila["idRemision"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsVenta CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsVenta obj = new clsVenta();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idRemision = Convert.ToInt32(fila["idRemision"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);

            }
            return obj;
		}
    }
}
