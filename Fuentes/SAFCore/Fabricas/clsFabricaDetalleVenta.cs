///////////////////////////////////////////////////////////
//  clsFabricaDetalleVenta.cs
//  Implementation of the Class clsDetalleVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleVenta
    {

        public clsFabricaDetalleVenta(){

		}

        ~clsFabricaDetalleVenta()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleVenta> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleVenta>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleVenta();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idVenta = Convert.ToInt32(fila["idVenta"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleVenta CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleVenta obj = new clsDetalleVenta();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idVenta = Convert.ToInt32(fila["idVenta"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
