///////////////////////////////////////////////////////////
//  clsOrdenServicio.cs
//  Implementation of the Class clsOrdenServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsOrdenServicio {

		#region Propiedades
		public Int32? Id;
public Int32? idRemision;
public Int16? idProveedor;
public Int32? Numero;

		#endregion 
		
		#region Construtores
		public clsOrdenServicio(){
			
		}

		~clsOrdenServicio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idRemision,idProveedor,Numero,
		}
		#endregion 

	}//end clsOrdenServicio

}//end namespace SAFCore