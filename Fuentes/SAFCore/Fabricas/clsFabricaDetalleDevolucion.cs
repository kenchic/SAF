///////////////////////////////////////////////////////////
//  clsFabricaDetalleDevolucion.cs
//  Implementation of the Class clsDetalleDevolucion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleDevolucion
    {

        public clsFabricaDetalleDevolucion(){

		}

        ~clsFabricaDetalleDevolucion()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleDevolucion> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleDevolucion>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleDevolucion();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucion = Convert.ToInt32(fila["idDevolucion"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleDevolucion CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleDevolucion obj = new clsDetalleDevolucion();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idDevolucion = Convert.ToInt32(fila["idDevolucion"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
