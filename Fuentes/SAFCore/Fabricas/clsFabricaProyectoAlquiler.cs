///////////////////////////////////////////////////////////
//  clsFabricaProyectoAlquiler.cs
//  Implementation of the Class clsProyectoAlquiler
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaProyectoAlquiler
    {

        public clsFabricaProyectoAlquiler(){

		}

        ~clsFabricaProyectoAlquiler()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsProyectoAlquiler> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsProyectoAlquiler>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsProyectoAlquiler();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyecto = Convert.ToInt16(fila["idProyecto"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsProyectoAlquiler CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsProyectoAlquiler obj = new clsProyectoAlquiler();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyecto = Convert.ToInt16(fila["idProyecto"]);

            }
            return obj;
		}
    }
}
