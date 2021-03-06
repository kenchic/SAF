///////////////////////////////////////////////////////////
//  clsFabricaDevolucionServicio.cs
//  Implementation of the Class clsDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDevolucionServicio
    {

        public clsFabricaDevolucionServicio(){

		}

        ~clsFabricaDevolucionServicio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDevolucionServicio> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDevolucionServicio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDevolucionServicio();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucion = Convert.ToInt32(fila["idDevolucion"]);
obj.idProveedor = Convert.ToInt16(fila["idProveedor"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDevolucionServicio CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDevolucionServicio obj = new clsDevolucionServicio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucion = Convert.ToInt32(fila["idDevolucion"]);
obj.idProveedor = Convert.ToInt16(fila["idProveedor"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);

            }
            return obj;
		}
    }
}
