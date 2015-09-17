///////////////////////////////////////////////////////////
//  clsFabricaProyectoVenta.cs
//  Implementation of the Class clsProyectoVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaProyectoVenta
    {

        public clsFabricaProyectoVenta(){

		}

        ~clsFabricaProyectoVenta()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsProyectoVenta> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsProyectoVenta>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsProyectoVenta();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyecto = Convert.ToInt16(fila["idProyecto"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsProyectoVenta CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsProyectoVenta obj = new clsProyectoVenta();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyecto = Convert.ToInt16(fila["idProyecto"]);

            }
            return obj;
		}
    }
}
