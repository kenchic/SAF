///////////////////////////////////////////////////////////
//  clsFabricaMenu.cs
//  Implementation of the Class clsMenu
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFseg 
{
    public class  clsFabricaMenu
    {

        public clsFabricaMenu(){

		}

        ~clsFabricaMenu()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsMenu> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsMenu>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsMenu();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idMenuNivel1 = Convert.ToInt16(fila["idMenuNivel1"]);
obj.idMenuNivel2 = Convert.ToInt16(fila["idMenuNivel2"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Url = fila["Url"].ToString();
obj.Orden = Convert.ToInt16(fila["Orden"]);
obj.Imagen = fila["Imagen"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsMenu CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsMenu obj = new clsMenu();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idMenuNivel1 = Convert.ToInt16(fila["idMenuNivel1"]);
obj.idMenuNivel2 = Convert.ToInt16(fila["idMenuNivel2"]);
obj.Nombre = fila["Nombre"].ToString();
obj.Url = fila["Url"].ToString();
obj.Orden = Convert.ToInt16(fila["Orden"]);
obj.Imagen = fila["Imagen"].ToString();
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
