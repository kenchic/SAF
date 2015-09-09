///////////////////////////////////////////////////////////
//  clsFabricaMenuRol.cs
//  Implementation of the Class clsMenuRol
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFseg 
{
    public class  clsFabricaMenuRol
    {

        public clsFabricaMenuRol(){

		}

        ~clsFabricaMenuRol()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsMenuRol> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsMenuRol>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsMenuRol();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idMenu = Convert.ToInt16(fila["idMenu"]);
obj.idRol = Convert.ToInt16(fila["idRol"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsMenuRol CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsMenuRol obj = new clsMenuRol();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idMenu = Convert.ToInt16(fila["idMenu"]);
obj.idRol = Convert.ToInt16(fila["idRol"]);

            }
            return obj;
		}
    }
}
