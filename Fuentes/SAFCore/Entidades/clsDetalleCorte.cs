///////////////////////////////////////////////////////////
//  clsDetalleCorte.cs
//  Implementation of the Class clsDetalleCorte
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleCorte {

		#region Propiedades
		public Int32? Id;
public Int32? idCorte;
public Int16? idElemento;
public Int32? idRemision;
public Int16? idProveedor;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleCorte(){
			
		}

		~clsDetalleCorte(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idCorte,idElemento,idRemision,idProveedor,Cantidad,
		}
		#endregion 

	}//end clsDetalleCorte

}//end namespace SAFCore