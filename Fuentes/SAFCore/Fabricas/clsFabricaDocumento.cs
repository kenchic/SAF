///////////////////////////////////////////////////////////
//  clsFabricaDocumento.cs
//  Implementation of the Class clsDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDocumento
    {

        public clsFabricaDocumento(){

		}

        ~clsFabricaDocumento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDocumento> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDocumento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDocumento();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idTipoDocumento = Convert.ToByte(fila["idTipoDocumento"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.Fecha = Convert.ToDateTime(fila["Fecha"]);
obj.Descripcion = fila["Descripcion"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDocumento CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDocumento obj = new clsDocumento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idTipoDocumento = Convert.ToByte(fila["idTipoDocumento"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.Fecha = Convert.ToDateTime(fila["Fecha"]);
obj.Descripcion = fila["Descripcion"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);

            }
            return obj;
		}
    }
}
