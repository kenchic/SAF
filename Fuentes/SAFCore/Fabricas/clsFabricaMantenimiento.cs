///////////////////////////////////////////////////////////
//  clsFabricaMantenimiento.cs
//  Implementation of the Class clsMantenimiento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaMantenimiento
    {

        public clsFabricaMantenimiento(){

		}

        ~clsFabricaMantenimiento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsMantenimiento> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsMantenimiento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsMantenimiento();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idDevolucion = Convert.ToInt16(fila["idDevolucion"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsMantenimiento CrearObjeto(System.Data.DataTable tabla){
		    clsMantenimiento obj = new clsMantenimiento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idDevolucion = Convert.ToInt16(fila["idDevolucion"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);

            }
            return obj;
		}
    }
}
