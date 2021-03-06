///////////////////////////////////////////////////////////
//  clsDevolucion.cs
//  Implementation of the Class clsDevolucion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDevolucion {

		#region Propiedades
		public Int32? Id;
public Int16? idProyecto;
public Int16? idConductor;
public Int32? Numero;
public String FechaAnunciada;
public String FechaRecogida;
public DateTime FechaCreacion;
public Boolean EntregaCliente;
public Boolean EntregaParcial;
public Byte? TipoMantenimiento;
public String Hora;
public Boolean Anulado;
public Decimal ValorTransporte;
public Decimal PesoEquipo;
public Decimal ValorEquipo;

		#endregion 
		
		#region Construtores
		public clsDevolucion(){
			
		}

		~clsDevolucion(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idProyecto,idConductor,Numero,FechaAnunciada,FechaRecogida,FechaCreacion,EntregaCliente,EntregaParcial,TipoMantenimiento,Hora,Anulado,ValorTransporte,PesoEquipo,ValorEquipo,
		}
		#endregion 

	}//end clsDevolucion

}//end namespace SAFCore