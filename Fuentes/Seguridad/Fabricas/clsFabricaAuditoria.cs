///////////////////////////////////////////////////////////
//  clsFabricaAuditoria.cs
//  Implementation of the Class clsAuditoria
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFseg 
{
    public class  clsFabricaAuditoria
    {

        public clsFabricaAuditoria(){

		}

        ~clsFabricaAuditoria()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsAuditoria> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsAuditoria>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsAuditoria();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idUsuario = Convert.ToInt16(fila["idUsuario"]);
obj.idEventosAuditoria = Convert.ToInt16(fila["idEventosAuditoria"]);
obj.IpTerminal = fila["IpTerminal"].ToString();
obj.Seccion = fila["Seccion"].ToString();
obj.Titulo = fila["Titulo"].ToString();
obj.Detalle = fila["Detalle"].ToString();

				lista.Add(obj);
            }
            return lista;
		}

        public clsAuditoria CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsAuditoria obj = new clsAuditoria();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idUsuario = Convert.ToInt16(fila["idUsuario"]);
obj.idEventosAuditoria = Convert.ToInt16(fila["idEventosAuditoria"]);
obj.IpTerminal = fila["IpTerminal"].ToString();
obj.Seccion = fila["Seccion"].ToString();
obj.Titulo = fila["Titulo"].ToString();
obj.Detalle = fila["Detalle"].ToString();

            }
            return obj;
		}
    }
}
