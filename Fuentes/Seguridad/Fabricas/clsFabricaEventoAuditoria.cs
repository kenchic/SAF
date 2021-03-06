///////////////////////////////////////////////////////////
//  clsFabricaEventoAuditoria.cs
//  Implementation of the Class clsEventoAuditoria
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFseg 
{
    public class  clsFabricaEventoAuditoria
    {

        public clsFabricaEventoAuditoria(){

		}

        ~clsFabricaEventoAuditoria()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsEventoAuditoria> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsEventoAuditoria>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsEventoAuditoria();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsEventoAuditoria CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsEventoAuditoria obj = new clsEventoAuditoria();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
