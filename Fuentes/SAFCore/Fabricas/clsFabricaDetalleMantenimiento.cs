///////////////////////////////////////////////////////////
//  clsFabricaDetalleMantenimiento.cs
//  Implementation of the Class clsDetalleMantenimiento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
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
		    var lista = new List<clsDetalleMantenimiento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsDetalleMantenimiento();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idMantenimiento = Convert.ToInt16(fila["idMantenimiento"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.TipoMantenimiento = Convert.ToInt16(fila["TipoMantenimiento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsDetalleMantenimiento CrearObjeto(System.Data.DataTable tabla){
		    clsDetalleMantenimiento obj = new clsDetalleMantenimiento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idMantenimiento = Convert.ToInt16(fila["idMantenimiento"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.TipoMantenimiento = Convert.ToInt16(fila["TipoMantenimiento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
