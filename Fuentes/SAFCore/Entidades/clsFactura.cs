///////////////////////////////////////////////////////////
//  clsFactura.cs
//  Implementation of the Class clsFactura
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsFactura {

		#region Propiedades
		public Int32? Id;
public Int32? idCorte;
public Int32? Numero;
public String FechaEmision;
public String FechaVencimiento;
public String Son;
public Decimal ParcialTotal;
public Byte? Dcto;
public Decimal SubTotal;
public Byte? Iva;
public Decimal Total;
public Boolean Anulada;
public Byte? idTipoFactura;

		#endregion 
		
		#region Construtores
		public clsFactura(){
			
		}

		~clsFactura(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idCorte,Numero,FechaEmision,FechaVencimiento,Son,ParcialTotal,Dcto,SubTotal,Iva,Total,Anulada,idTipoFactura,
		}
		#endregion 

	}//end clsFactura

}//end namespace SAFCore