///////////////////////////////////////////////////////////
//  clsDevolucionServicio.cs
//  Implementation of the Class clsDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDevolucionServicio {

		#region Propiedades
		public Int32? Id;
public Int32? idDevolucion;
public Int16? idProveedor;
public Int32? Numero;

		#endregion 
		
		#region Construtores
		public clsDevolucionServicio(){
			
		}

		~clsDevolucionServicio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idDevolucion,idProveedor,Numero,
		}
		#endregion 

	}//end clsDevolucionServicio

}//end namespace SAFCore