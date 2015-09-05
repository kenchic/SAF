///////////////////////////////////////////////////////////
//  clsFabricaDetalleDevolucion.cs
//  Implementation of the Class clsDetalleDevolucion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
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
		    var lista = new List<clsDetalleDevolucion>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsDetalleDevolucion();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idDevolucion = Convert.ToInt16(fila["idDevolucion"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsDetalleDevolucion CrearObjeto(System.Data.DataTable tabla){
		    clsDetalleDevolucion obj = new clsDetalleDevolucion();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idDevolucion = Convert.ToInt16(fila["idDevolucion"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
