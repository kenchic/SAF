///////////////////////////////////////////////////////////
//  clsDetalleMantenimiento.cs
//  Implementation of the Class clsDetalleMantenimiento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleMantenimiento {

		#region Propiedades
		public Int32? Id;
public Int32? idMantenimiento;
public Int16? idElemento;
public Int16? TipoMantenimiento;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleMantenimiento(){
			
		}

		~clsDetalleMantenimiento(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idMantenimiento,idElemento,TipoMantenimiento,Cantidad,
		}
		#endregion 

	}//end clsDetalleMantenimiento

}//end namespace SAFCore