///////////////////////////////////////////////////////////
//  clsCorte.cs
//  Implementation of the Class clsCorte
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsCorte {

		#region Propiedades
		public Int32? Id;
public Int16? idProyectoVenta;
public Int16? idProyectoAlquiler;
public Int32? Numero;
public String Fecha;

		#endregion 
		
		#region Construtores
		public clsCorte(){
			
		}

		~clsCorte(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idProyectoVenta,idProyectoAlquiler,Numero,Fecha,
		}
		#endregion 

	}//end clsCorte

}//end namespace SAFCore