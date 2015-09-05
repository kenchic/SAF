///////////////////////////////////////////////////////////
//  clsFabricaRemision.cs
//  Implementation of the Class clsRemision
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaRemision
    {

        public clsFabricaRemision(){

		}

        ~clsFabricaRemision()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsRemision> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsRemision>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsRemision();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyectoAlquiler = Convert.ToInt16(fila["idProyectoAlquiler"]);
obj.idProyectoVenta = Convert.ToInt16(fila["idProyectoVenta"]);
obj.idConductor = Convert.ToInt16(fila["idConductor"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);
obj.FechaPedido = fila["FechaPedido"].ToString();
obj.FechaEntrega = fila["FechaEntrega"].ToString();
obj.Hora = fila["Hora"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);
obj.Transporte = Convert.ToBoolean(fila["Transporte"]);
obj.Despachado = Convert.ToBoolean(fila["Despachado"]);
obj.EquipoAdecuado = Convert.ToBoolean(fila["EquipoAdecuado"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsRemision CrearObjeto(System.Data.DataTable tabla){
		    clsRemision obj = new clsRemision();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idProyectoAlquiler = Convert.ToInt16(fila["idProyectoAlquiler"]);
obj.idProyectoVenta = Convert.ToInt16(fila["idProyectoVenta"]);
obj.idConductor = Convert.ToInt16(fila["idConductor"]);
obj.Numero = Convert.ToInt16(fila["Numero"]);
obj.FechaPedido = fila["FechaPedido"].ToString();
obj.FechaEntrega = fila["FechaEntrega"].ToString();
obj.Hora = fila["Hora"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);
obj.Transporte = Convert.ToBoolean(fila["Transporte"]);
obj.Despachado = Convert.ToBoolean(fila["Despachado"]);
obj.EquipoAdecuado = Convert.ToBoolean(fila["EquipoAdecuado"]);

            }
            return obj;
		}
    }
}
