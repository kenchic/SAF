///////////////////////////////////////////////////////////
//  clsFabricaMantenimiento.cs
//  Implementation of the Class clsMantenimiento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaMantenimiento
    {

        public clsFabricaMantenimiento(){

		}

        ~clsFabricaMantenimiento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsMantenimiento> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsMantenimiento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsMantenimiento();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucion = Convert.ToInt32(fila["idDevolucion"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsMantenimiento CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsMantenimiento obj = new clsMantenimiento();
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
