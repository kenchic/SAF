///////////////////////////////////////////////////////////
//  clsDetalleRepDevolucionServicio.cs
//  Implementation of the Class clsDetalleRepDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleRepDevolucionServicio {

		#region Propiedades
		public Int32? Id;
public Int32? idRepDevolucionServicio;
public Int16? idElemento;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleRepDevolucionServicio(){
			
		}

		~clsDetalleRepDevolucionServicio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idRepDevolucionServicio,idElemento,Cantidad,
		}
		#endregion 

	}//end clsDetalleRepDevolucionServicio

}//end namespace SAFCore