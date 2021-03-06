///////////////////////////////////////////////////////////
//  clsFabricaAgente.cs
//  Implementation of the Class clsAgente
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaAgente
    {

        public clsFabricaAgente(){

		}

        ~clsFabricaAgente()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsAgente> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsAgente>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsAgente();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsAgente CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsAgente obj = new clsAgente();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
