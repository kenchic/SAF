///////////////////////////////////////////////////////////
//  clsFabricaFactura.cs
//  Implementation of the Class clsFactura
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaFactura
    {

        public clsFabricaFactura(){

		}

        ~clsFabricaFactura()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsFactura> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsFactura>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsFactura();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idCorte = Convert.ToInt32(fila["idCorte"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.FechaEmision = fila["FechaEmision"].ToString();
obj.FechaVencimiento = fila["FechaVencimiento"].ToString();
obj.Son = fila["Son"].ToString();
obj.ParcialTotal = Convert.ToDecimal(fila["ParcialTotal"]);
obj.Dcto = Convert.ToByte(fila["Dcto"]);
obj.SubTotal = Convert.ToDecimal(fila["SubTotal"]);
obj.Iva = Convert.ToByte(fila["Iva"]);
obj.Total = Convert.ToDecimal(fila["Total"]);
obj.Anulada = Convert.ToBoolean(fila["Anulada"]);
obj.idTipoFactura = Convert.ToByte(fila["idTipoFactura"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsFactura CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsFactura obj = new clsFactura();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idCorte = Convert.ToInt32(fila["idCorte"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.FechaEmision = fila["FechaEmision"].ToString();
obj.FechaVencimiento = fila["FechaVencimiento"].ToString();
obj.Son = fila["Son"].ToString();
obj.ParcialTotal = Convert.ToDecimal(fila["ParcialTotal"]);
obj.Dcto = Convert.ToByte(fila["Dcto"]);
obj.SubTotal = Convert.ToDecimal(fila["SubTotal"]);
obj.Iva = Convert.ToByte(fila["Iva"]);
obj.Total = Convert.ToDecimal(fila["Total"]);
obj.Anulada = Convert.ToBoolean(fila["Anulada"]);
obj.idTipoFactura = Convert.ToByte(fila["idTipoFactura"]);

            }
            return obj;
		}
    }
}
