///////////////////////////////////////////////////////////
//  clsFabricaProveedor.cs
//  Implementation of the Class clsProveedor
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaProveedor
    {

        public clsFabricaProveedor(){

		}

        ~clsFabricaProveedor()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsProveedor> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsProveedor>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsProveedor();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.Identificacion = fila["Identificacion"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Iniciales = fila["Iniciales"].ToString();
obj.Telefono = fila["Telefono"].ToString();
obj.Direccion = fila["Direccion"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsProveedor CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsProveedor obj = new clsProveedor();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.Identificacion = fila["Identificacion"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Iniciales = fila["Iniciales"].ToString();
obj.Telefono = fila["Telefono"].ToString();
obj.Direccion = fila["Direccion"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
