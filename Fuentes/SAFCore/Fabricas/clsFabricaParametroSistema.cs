///////////////////////////////////////////////////////////
//  clsFabricaParametroSistema.cs
//  Implementation of the Class clsParametroSistema
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaParametroSistema
    {

        public clsFabricaParametroSistema(){

		}

        ~clsFabricaParametroSistema()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsParametroSistema> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsParametroSistema>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsParametroSistema();
				obj.Codigo = fila["Codigo"].ToString();
obj.idParametro = Convert.ToInt16(fila["idParametro"]);
obj.Valor = fila["Valor"].ToString();

				lista.Add(obj);
            }
            return lista;
		}

        public clsParametroSistema CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsParametroSistema obj = new clsParametroSistema();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Codigo = fila["Codigo"].ToString();
obj.idParametro = Convert.ToInt16(fila["idParametro"]);
obj.Valor = fila["Valor"].ToString();

            }
            return obj;
		}
    }
}
