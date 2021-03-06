///////////////////////////////////////////////////////////
//  clsFabricaDetalleCorte.cs
//  Implementation of the Class clsDetalleCorte
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleCorte
    {

        public clsFabricaDetalleCorte(){

		}

        ~clsFabricaDetalleCorte()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleCorte> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleCorte>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleCorte();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idCorte = Convert.ToInt32(fila["idCorte"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idRemision = Convert.ToInt32(fila["idRemision"]);
obj.idProveedor = Convert.ToInt16(fila["idProveedor"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleCorte CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleCorte obj = new clsDetalleCorte();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idCorte = Convert.ToInt32(fila["idCorte"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.idRemision = Convert.ToInt32(fila["idRemision"]);
obj.idProveedor = Convert.ToInt16(fila["idProveedor"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
