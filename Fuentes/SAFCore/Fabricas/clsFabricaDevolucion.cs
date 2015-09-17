///////////////////////////////////////////////////////////
//  clsFabricaDevolucion.cs
//  Implementation of the Class clsDevolucion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaDevolucion
    {

        public clsFabricaDevolucion(){

		}

        ~clsFabricaDevolucion()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsDevolucion> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsDevolucion>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsDevolucion();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyecto = Convert.ToInt16(fila["idProyecto"]);
obj.idConductor = Convert.ToInt16(fila["idConductor"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);
obj.FechaAnunciada = fila["FechaAnunciada"].ToString();
obj.FechaRecogida = fila["FechaRecogida"].ToString();
obj.EntregaCliente = Convert.ToBoolean(fila["EntregaCliente"]);
obj.EntregaParcial = Convert.ToBoolean(fila["EntregaParcial"]);
obj.Hora = fila["Hora"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsDevolucion CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsDevolucion obj = new clsDevolucion();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyecto = Convert.ToInt16(fila["idProyecto"]);
obj.idConductor = Convert.ToInt16(fila["idConductor"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);
obj.FechaAnunciada = fila["FechaAnunciada"].ToString();
obj.FechaRecogida = fila["FechaRecogida"].ToString();
obj.EntregaCliente = Convert.ToBoolean(fila["EntregaCliente"]);
obj.EntregaParcial = Convert.ToBoolean(fila["EntregaParcial"]);
obj.Hora = fila["Hora"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);

            }
            return obj;
		}
    }
}
