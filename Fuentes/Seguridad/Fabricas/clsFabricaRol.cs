///////////////////////////////////////////////////////////
//  clsFabricaRol.cs
//  Implementation of the Class clsRol
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaRol
    {

        public clsFabricaRol(){

		}

        ~clsFabricaRol()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsRol> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsRol>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsRol();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsRol CrearObjeto(System.Data.DataTable tabla){
		    clsRol obj = new clsRol();
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
