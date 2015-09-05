///////////////////////////////////////////////////////////
//  clsFabricaGrupoElemento.cs
//  Implementation of the Class clsGrupoElemento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaGrupoElemento
    {

        public clsFabricaGrupoElemento(){

		}

        ~clsFabricaGrupoElemento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsGrupoElemento> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsGrupoElemento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsGrupoElemento();
                obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsGrupoElemento CrearObjeto(System.Data.DataTable tabla){
		    clsGrupoElemento obj = new clsGrupoElemento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Nombre = fila["Nombre"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
