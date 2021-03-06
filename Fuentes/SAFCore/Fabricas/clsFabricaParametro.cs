///////////////////////////////////////////////////////////
//  clsFabricaParametro.cs
//  Implementation of the Class clsParametro
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaParametro
    {

        public clsFabricaParametro(){

		}

        ~clsFabricaParametro()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsParametro> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsParametro>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsParametro();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();

				lista.Add(obj);
            }
            return lista;
		}

        public clsParametro CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsParametro obj = new clsParametro();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();

            }
            return obj;
		}
    }
}
