///////////////////////////////////////////////////////////
//  clsFabricaDetalleListaPrecio.cs
//  Implementation of the Class clsDetalleListaPrecio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleListaPrecio
    {

        public clsFabricaDetalleListaPrecio(){

		}

        ~clsFabricaDetalleListaPrecio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleListaPrecio> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleListaPrecio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleListaPrecio();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idListaPrecios = Convert.ToByte(fila["idListaPrecios"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.PrecioAlquiler = Convert.ToInt32(fila["PrecioAlquiler"]);
obj.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
obj.PrecioPerdida = Convert.ToInt32(fila["PrecioPerdida"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleListaPrecio CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleListaPrecio obj = new clsDetalleListaPrecio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idListaPrecios = Convert.ToByte(fila["idListaPrecios"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.PrecioAlquiler = Convert.ToInt32(fila["PrecioAlquiler"]);
obj.PrecioVenta = Convert.ToInt32(fila["PrecioVenta"]);
obj.PrecioPerdida = Convert.ToInt32(fila["PrecioPerdida"]);

            }
            return obj;
		}
    }
}
