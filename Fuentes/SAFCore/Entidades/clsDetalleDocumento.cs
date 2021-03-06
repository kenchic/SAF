///////////////////////////////////////////////////////////
//  clsDetalleDocumento.cs
//  Implementation of the Class clsDetalleDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleDocumento {

		#region Propiedades
		public Int32? Id;
public Int16? idElemento;
public Int32? idDocumento;
public Byte? idBodegaDestino;
public Byte? idBodegaOrigen;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleDocumento(){
			
		}

		~clsDetalleDocumento(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idElemento,idDocumento,idBodegaDestino,idBodegaOrigen,Cantidad,
		}
		#endregion 

	}//end clsDetalleDocumento

}//end namespace SAFCore