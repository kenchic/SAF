///////////////////////////////////////////////////////////
//  clsFabricaDetalleOrdenServicio.cs
//  Implementation of the Class clsDetalleOrdenServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaDetalleOrdenServicio
    {

        public clsFabricaDetalleOrdenServicio(){

		}

        ~clsFabricaDetalleOrdenServicio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleOrdenServicio> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsDetalleOrdenServicio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsDetalleOrdenServicio();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idOrdenServicio = Convert.ToInt16(fila["idOrdenServicio"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsDetalleOrdenServicio CrearObjeto(System.Data.DataTable tabla){
		    clsDetalleOrdenServicio obj = new clsDetalleOrdenServicio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idOrdenServicio = Convert.ToInt16(fila["idOrdenServicio"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
