///////////////////////////////////////////////////////////
//  clsFabricaCliente.cs
//  Implementation of the Class clsCliente
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaCliente
    {

        public clsFabricaCliente(){

		}

        ~clsFabricaCliente()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsCliente> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsCliente>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsCliente();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idCiudad = Convert.ToInt16(fila["idCiudad"]);
obj.Identificacion = fila["Identificacion"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Direccion = fila["Direccion"].ToString();
obj.Telefono = fila["Telefono"].ToString();
obj.Celular = fila["Celular"].ToString();
obj.Correo = fila["Correo"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsCliente CrearObjeto(System.Data.DataTable tabla){
		    clsCliente obj = new clsCliente();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idCiudad = Convert.ToInt16(fila["idCiudad"]);
obj.Identificacion = fila["Identificacion"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Direccion = fila["Direccion"].ToString();
obj.Telefono = fila["Telefono"].ToString();
obj.Celular = fila["Celular"].ToString();
obj.Correo = fila["Correo"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
