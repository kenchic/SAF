///////////////////////////////////////////////////////////
//  clsFabricaDetalleRemision.cs
//  Implementation of the Class clsDetalleRemision
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDetalleRemision
    {

        public clsFabricaDetalleRemision(){

		}

        ~clsFabricaDetalleRemision()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleRemision> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDetalleRemision>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDetalleRemision();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idRemision = Convert.ToInt32(fila["idRemision"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDetalleRemision CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDetalleRemision obj = new clsDetalleRemision();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idRemision = Convert.ToInt32(fila["idRemision"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt32(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
