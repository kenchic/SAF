///////////////////////////////////////////////////////////
//  clsFabricaRepDevolucionServicio.cs
//  Implementation of the Class clsRepDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaRepDevolucionServicio
    {

        public clsFabricaRepDevolucionServicio(){

		}

        ~clsFabricaRepDevolucionServicio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsRepDevolucionServicio> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsRepDevolucionServicio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsRepDevolucionServicio();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucion = Convert.ToInt32(fila["idDevolucion"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsRepDevolucionServicio CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsRepDevolucionServicio obj = new clsRepDevolucionServicio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucion = Convert.ToInt32(fila["idDevolucion"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);

            }
            return obj;
		}
    }
}
