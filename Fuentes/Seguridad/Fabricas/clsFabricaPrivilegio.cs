///////////////////////////////////////////////////////////
//  clsFabricaPrivilegio.cs
//  Implementation of the Class clsPrivilegio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFseg 
{
    public class  clsFabricaPrivilegio
    {

        public clsFabricaPrivilegio(){

		}

        ~clsFabricaPrivilegio()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsPrivilegio> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsPrivilegio>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsPrivilegio();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.IdPrivilegioPadre = Convert.ToInt16(fila["IdPrivilegioPadre"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsPrivilegio CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsPrivilegio obj = new clsPrivilegio();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.IdPrivilegioPadre = Convert.ToInt16(fila["IdPrivilegioPadre"]);

            }
            return obj;
		}
    }
}
