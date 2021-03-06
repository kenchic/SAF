///////////////////////////////////////////////////////////
//  clsFabricaDetalleDevolucionServicio.cs
//  Implementation of the Class clsDetalleDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleDevolucionServicio
    {

        public clsFabricaDetalleDevolucionServicio(){

		}

        ~clsFabricaDetalleDevolucionServicio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleDevolucionServicio> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleDevolucionServicio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleDevolucionServicio();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucionServicio = Convert.ToInt32(fila["idDevolucionServicio"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleDevolucionServicio CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleDevolucionServicio obj = new clsDetalleDevolucionServicio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucionServicio = Convert.ToInt32(fila["idDevolucionServicio"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
