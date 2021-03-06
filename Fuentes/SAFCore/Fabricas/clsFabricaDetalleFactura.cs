///////////////////////////////////////////////////////////
//  clsFabricaDetalleFactura.cs
//  Implementation of the Class clsDetalleFactura
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleFactura
    {

        public clsFabricaDetalleFactura(){

		}

        ~clsFabricaDetalleFactura()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleFactura> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleFactura>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleFactura();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idFactura = Convert.ToInt32(fila["idFactura"]);
obj.Detalle = fila["Detalle"].ToString();
obj.Dias = Convert.ToByte(fila["Dias"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);
obj.Valor = Convert.ToInt32(fila["Valor"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleFactura CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleFactura obj = new clsDetalleFactura();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idFactura = Convert.ToInt32(fila["idFactura"]);
obj.Detalle = fila["Detalle"].ToString();
obj.Dias = Convert.ToByte(fila["Dias"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);
obj.Valor = Convert.ToInt32(fila["Valor"]);

            }
            return obj;
		}
    }
}
