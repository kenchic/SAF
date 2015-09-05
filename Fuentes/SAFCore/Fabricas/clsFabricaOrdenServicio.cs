///////////////////////////////////////////////////////////
//  clsFabricaOrdenServicio.cs
//  Implementation of the Class clsOrdenServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaOrdenServicio
    {

        public clsFabricaOrdenServicio(){

		}

        ~clsFabricaOrdenServicio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsOrdenServicio> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsOrdenServicio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsOrdenServicio();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idRemision = Convert.ToInt16(fila["idRemision"]);
obj.idProveedor = Convert.ToInt16(fila["idProveedor"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsOrdenServicio CrearObjeto(System.Data.DataTable tabla){
		    clsOrdenServicio obj = new clsOrdenServicio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idRemision = Convert.ToInt16(fila["idRemision"]);
obj.idProveedor = Convert.ToInt16(fila["idProveedor"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);

            }
            return obj;
		}
    }
}
