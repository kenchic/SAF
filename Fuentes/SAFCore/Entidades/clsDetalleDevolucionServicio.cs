///////////////////////////////////////////////////////////
//  clsDetalleDevolucionServicio.cs
//  Implementation of the Class clsDetalleDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleDevolucionServicio {

		#region Propiedades
		public Int32? Id;
public Int32? idDevolucionServicio;
public Int16? idElemento;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleDevolucionServicio(){
			
		}

		~clsDetalleDevolucionServicio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idDevolucionServicio,idElemento,Cantidad,
		}
		#endregion 

	}//end clsDetalleDevolucionServicio

}//end namespace SAFCore