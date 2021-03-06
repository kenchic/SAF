///////////////////////////////////////////////////////////
//  clsFabricaRemision.cs
//  Implementation of the Class clsRemision
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
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
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsRemision>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsRemision();
				obj.Id = Convert.ToInt32(fila["Id"]);
obj.idProyectoAlquiler = Convert.ToInt16(fila["idProyectoAlquiler"]);
obj.idProyectoVenta = Convert.ToInt16(fila["idProyectoVenta"]);
obj.idConductor = Convert.ToInt16(fila["idConductor"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.FechaPedido = fila["FechaPedido"].ToString();
obj.FechaEntrega = fila["FechaEntrega"].ToString();
obj.FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"]);
obj.Hora = fila["Hora"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);
obj.Transporte = Convert.ToBoolean(fila["Transporte"]);
obj.ValorTransporte = Convert.ToDecimal(fila["ValorTransporte"]);
obj.Despachado = Convert.ToBoolean(fila["Despachado"]);
obj.EquipoAdecuado = Convert.ToBoolean(fila["EquipoAdecuado"]);
obj.PesoEquipo = Convert.ToDecimal(fila["PesoEquipo"]);
obj.ValorEquipo = Convert.ToDecimal(fila["ValorEquipo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsRemision CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsRemision obj = new clsRemision();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt32(fila["Id"]);
obj.idProyectoAlquiler = Convert.ToInt16(fila["idProyectoAlquiler"]);
obj.idProyectoVenta = Convert.ToInt16(fila["idProyectoVenta"]);
obj.idConductor = Convert.ToInt16(fila["idConductor"]);
obj.Numero = Convert.ToInt32(fila["Numero"]);
obj.FechaPedido = fila["FechaPedido"].ToString();
obj.FechaEntrega = fila["FechaEntrega"].ToString();
obj.FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"]);
obj.Hora = fila["Hora"].ToString();
obj.Anulado = Convert.ToBoolean(fila["Anulado"]);
obj.Transporte = Convert.ToBoolean(fila["Transporte"]);
obj.ValorTransporte = Convert.ToDecimal(fila["ValorTransporte"]);
obj.Despachado = Convert.ToBoolean(fila["Despachado"]);
obj.EquipoAdecuado = Convert.ToBoolean(fila["EquipoAdecuado"]);
obj.PesoEquipo = Convert.ToDecimal(fila["PesoEquipo"]);
obj.ValorEquipo = Convert.ToDecimal(fila["ValorEquipo"]);

            }
            return obj;
		}
    }
}
