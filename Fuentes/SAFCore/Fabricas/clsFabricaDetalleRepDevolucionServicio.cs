///////////////////////////////////////////////////////////
//  clsFabricaDetalleRepDevolucionServicio.cs
//  Implementation of the Class clsDetalleRepDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleRepDevolucionServicio
    {

        public clsFabricaDetalleRepDevolucionServicio(){

		}

        ~clsFabricaDetalleRepDevolucionServicio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleRepDevolucionServicio> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleRepDevolucionServicio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleRepDevolucionServicio();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idRepDevolucionServicio = Convert.ToInt32(fila["idRepDevolucionServicio"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleRepDevolucionServicio CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleRepDevolucionServicio obj = new clsDetalleRepDevolucionServicio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idRepDevolucionServicio = Convert.ToInt32(fila["idRepDevolucionServicio"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
