///////////////////////////////////////////////////////////
//  clsFabricaUsuario.cs
//  Implementation of the Class clsUsuario
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFseg 
{
    public class  clsFabricaUsuario
    {

        public clsFabricaUsuario(){

		}

        ~clsFabricaUsuario()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsUsuario> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsUsuario>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsUsuario();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idRol = Convert.ToInt16(fila["idRol"]);
obj.Identificacion = fila["Identificacion"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Apellido = fila["Apellido"].ToString();
obj.Usuario = fila["Usuario"].ToString();
obj.Clave = fila["Clave"].ToString();
obj.Correo = fila["Correo"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Admin = Convert.ToBoolean(fila["Admin"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsUsuario CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsUsuario obj = new clsUsuario();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idRol = Convert.ToInt16(fila["idRol"]);
obj.Identificacion = fila["Identificacion"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Apellido = fila["Apellido"].ToString();
obj.Usuario = fila["Usuario"].ToString();
obj.Clave = fila["Clave"].ToString();
obj.Correo = fila["Correo"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Admin = Convert.ToBoolean(fila["Admin"]);

            }
            return obj;
		}
    }
}
