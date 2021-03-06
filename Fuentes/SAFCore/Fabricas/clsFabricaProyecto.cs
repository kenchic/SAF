///////////////////////////////////////////////////////////
//  clsFabricaProyecto.cs
//  Implementation of the Class clsProyecto
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaProyecto
    {

        public clsFabricaProyecto(){

		}

        ~clsFabricaProyecto()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsProyecto> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsProyecto>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsProyecto();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idCliente = Convert.ToInt32(fila["idCliente"]);
obj.idCiudad = Convert.ToInt16(fila["idCiudad"]);
obj.NombreCliente = fila["NombreCliente"].ToString();
obj.NombreCiudad = fila["NombreCiudad"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Tipo = fila["Tipo"].ToString();
obj.Direccion = fila["Direccion"].ToString();
obj.Telefono = fila["Telefono"].ToString();
obj.Observacion = fila["Observacion"].ToString();
obj.Fecha = fila["Fecha"].ToString();
obj.FormaContacto = fila["FormaContacto"].ToString();
obj.SistemaMedida = fila["SistemaMedida"].ToString();
obj.IdentificacionResponsable = fila["IdentificacionResponsable"].ToString();
obj.NombreResponsable = fila["NombreResponsable"].ToString();
obj.TelResponsable = fila["TelResponsable"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Estado = Convert.ToByte(fila["Estado"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsProyecto CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsProyecto obj = new clsProyecto();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idCliente = Convert.ToInt32(fila["idCliente"]);
obj.idCiudad = Convert.ToInt16(fila["idCiudad"]);
obj.NombreCliente = fila["NombreCliente"].ToString();
obj.NombreCiudad = fila["NombreCiudad"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Tipo = fila["Tipo"].ToString();
obj.Direccion = fila["Direccion"].ToString();
obj.Telefono = fila["Telefono"].ToString();
obj.Observacion = fila["Observacion"].ToString();
obj.Fecha = fila["Fecha"].ToString();
obj.FormaContacto = fila["FormaContacto"].ToString();
obj.SistemaMedida = fila["SistemaMedida"].ToString();
obj.IdentificacionResponsable = fila["IdentificacionResponsable"].ToString();
obj.NombreResponsable = fila["NombreResponsable"].ToString();
obj.TelResponsable = fila["TelResponsable"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Estado = Convert.ToByte(fila["Estado"]);

            }
            return obj;
		}
    }
}
