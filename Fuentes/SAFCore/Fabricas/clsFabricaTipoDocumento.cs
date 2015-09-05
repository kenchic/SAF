///////////////////////////////////////////////////////////
//  clsFabricaTipoDocumento.cs
//  Implementation of the Class clsTipoDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
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
		    var lista = new List<clsTipoDocumento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsTipoDocumento();
                obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Operacion = fila["Operacion"].ToString();

                lista.Add(obj);
            }
            return lista;
		}

public clsTipoDocumento CrearObjeto(System.Data.DataTable tabla){
		    clsTipoDocumento obj = new clsTipoDocumento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);
obj.Operacion = fila["Operacion"].ToString();

            }
            return obj;
		}
    }
}
