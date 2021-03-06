///////////////////////////////////////////////////////////
//  clsFabricaDetalleMantenimiento.cs
//  Implementation of the Class clsDetalleMantenimiento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleMantenimiento
    {

        public clsFabricaDetalleMantenimiento(){

		}

        ~clsFabricaDetalleMantenimiento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleMantenimiento> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleMantenimiento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleMantenimiento();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idMantenimiento = Convert.ToInt32(fila["idMantenimiento"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.TipoMantenimiento = Convert.ToInt16(fila["TipoMantenimiento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleMantenimiento CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleMantenimiento obj = new clsDetalleMantenimiento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idMantenimiento = Convert.ToInt32(fila["idMantenimiento"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.TipoMantenimiento = Convert.ToInt16(fila["TipoMantenimiento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
