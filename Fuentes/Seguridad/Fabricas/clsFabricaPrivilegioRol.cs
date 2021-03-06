///////////////////////////////////////////////////////////
//  clsFabricaPrivilegioRol.cs
//  Implementation of the Class clsPrivilegioRol
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFseg 
{
    public class  clsFabricaPrivilegioRol
    {

        public clsFabricaPrivilegioRol(){

		}

        ~clsFabricaPrivilegioRol()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsPrivilegioRol> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsPrivilegioRol>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsPrivilegioRol();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idRol = Convert.ToInt16(fila["idRol"]);
obj.idPrivilegio = Convert.ToInt16(fila["idPrivilegio"]);
obj.Valor = Convert.ToInt16(fila["Valor"]);
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsPrivilegioRol CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsPrivilegioRol obj = new clsPrivilegioRol();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idRol = Convert.ToInt16(fila["idRol"]);
obj.idPrivilegio = Convert.ToInt16(fila["idPrivilegio"]);
obj.Valor = Convert.ToInt16(fila["Valor"]);
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
