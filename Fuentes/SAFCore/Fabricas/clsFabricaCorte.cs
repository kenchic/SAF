///////////////////////////////////////////////////////////
//  clsFabricaCorte.cs
//  Implementation of the Class clsCorte
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaCorte
    {

        public clsFabricaCorte(){

		}

        ~clsFabricaCorte()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsCorte> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsCorte>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsCorte();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idProyectoVenta = Convert.ToInt16(fila["idProyectoVenta"]);
obj.idProyectoAlquiler = Convert.ToInt16(fila["idProyectoAlquiler"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.Fecha = fila["Fecha"].ToString();

				lista.Add(obj);
            }
            return lista;
		}

        public clsCorte CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsCorte obj = new clsCorte();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idProyectoVenta = Convert.ToInt16(fila["idProyectoVenta"]);
obj.idProyectoAlquiler = Convert.ToInt16(fila["idProyectoAlquiler"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.Fecha = fila["Fecha"].ToString();

            }
            return obj;
		}
    }
}
