///////////////////////////////////////////////////////////
//  clsFabricaMovimientoBodega.cs
//  Implementation of the Class clsMovimientoBodega
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaMovimientoBodega
    {

        public clsFabricaMovimientoBodega(){

		}

        ~clsFabricaMovimientoBodega()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsMovimientoBodega> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsMovimientoBodega>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsMovimientoBodega();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemeto = Convert.ToInt16(fila["idElemeto"]);
obj.idBodegaOrigen = Convert.ToByte(fila["idBodegaOrigen"]);
obj.idBodegaDestino = Convert.ToByte(fila["idBodegaDestino"]);
obj.Fecha = Convert.ToDateTime(fila["Fecha"]);
obj.Documento = fila["Documento"].ToString();
obj.Numero = fila["Numero"].ToString();
obj.Operacion = fila["Operacion"].ToString();
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsMovimientoBodega CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsMovimientoBodega obj = new clsMovimientoBodega();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemeto = Convert.ToInt16(fila["idElemeto"]);
obj.idBodegaOrigen = Convert.ToByte(fila["idBodegaOrigen"]);
obj.idBodegaDestino = Convert.ToByte(fila["idBodegaDestino"]);
obj.Fecha = Convert.ToDateTime(fila["Fecha"]);
obj.Documento = fila["Documento"].ToString();
obj.Numero = fila["Numero"].ToString();
obj.Operacion = fila["Operacion"].ToString();
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
