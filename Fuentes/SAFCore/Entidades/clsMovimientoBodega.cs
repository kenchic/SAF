///////////////////////////////////////////////////////////
//  clsMovimientoBodega.cs
//  Implementation of the Class clsMovimientoBodega
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsMovimientoBodega {

		#region Propiedades
		public Int32? Id;
public Int16? idElemeto;
public Byte? idBodegaOrigen;
public Byte? idBodegaDestino;
public DateTime Fecha;
public String Documento;
public String Numero;
public String Operacion;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsMovimientoBodega(){
			
		}

		~clsMovimientoBodega(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idElemeto,idBodegaOrigen,idBodegaDestino,Fecha,Documento,Numero,Operacion,Cantidad,
		}
		#endregion 

	}//end clsMovimientoBodega

}//end namespace SAFCore