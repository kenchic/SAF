///////////////////////////////////////////////////////////
//  clsFabricaDetalleReposicion.cs
//  Implementation of the Class clsDetalleReposicion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaDetalleReposicion
    {

        public clsFabricaDetalleReposicion(){

		}

        ~clsFabricaDetalleReposicion()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDetalleReposicion> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsDetalleReposicion>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsDetalleReposicion();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idReposicion = Convert.ToInt16(fila["idReposicion"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsDetalleReposicion CrearObjeto(System.Data.DataTable tabla){
		    clsDetalleReposicion obj = new clsDetalleReposicion();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idReposicion = Convert.ToInt16(fila["idReposicion"]);
obj.idElemento = Convert.ToInt16(fila["idElemento"]);
obj.Cantidad = Convert.ToInt16(fila["Cantidad"]);

            }
            return obj;
		}
    }
}
