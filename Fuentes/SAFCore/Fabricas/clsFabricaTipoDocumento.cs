///////////////////////////////////////////////////////////
//  clsFabricaTipoDocumento.cs
//  Implementation of the Class clsTipoDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaTipoDocumento
    {

        public clsFabricaTipoDocumento(){

		}

        ~clsFabricaTipoDocumento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsTipoDocumento> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsTipoDocumento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsTipoDocumento();
				obj.Id = Convert.ToByte(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Consecutivo = Convert.ToInt64(fila["Consecutivo"]);
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Operacion = fila["Operacion"].ToString();

				lista.Add(obj);
            }
            return lista;
		}

        public clsTipoDocumento CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsTipoDocumento obj = new clsTipoDocumento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToByte(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Consecutivo = Convert.ToInt64(fila["Consecutivo"]);
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Operacion = fila["Operacion"].ToString();

            }
            return obj;
		}
    }
}
