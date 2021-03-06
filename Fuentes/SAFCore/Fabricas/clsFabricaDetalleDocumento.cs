///////////////////////////////////////////////////////////
//  clsFabricaDetalleDocumento.cs
//  Implementation of the Class clsDetalleDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleDocumento
    {

        public clsFabricaDetalleDocumento(){

		}

        ~clsFabricaDetalleDocumento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleDocumento> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleDocumento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleDocumento();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idDocumento = Convert.ToInt32(fila["idDocumento"]);
obj.idBodegaDestino = Convert.ToByte(fila["idBodegaDestino"]);
obj.idBodegaOrigen = Convert.ToByte(fila["idBodegaOrigen"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleDocumento CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleDocumento obj = new clsDetalleDocumento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idDocumento = Convert.ToInt32(fila["idDocumento"]);
obj.idBodegaDestino = Convert.ToByte(fila["idBodegaDestino"]);
obj.idBodegaOrigen = Convert.ToByte(fila["idBodegaOrigen"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
