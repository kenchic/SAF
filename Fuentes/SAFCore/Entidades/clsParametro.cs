///////////////////////////////////////////////////////////
//  clsParametro.cs
//  Implementation of the Class clsParametro
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsParametro {

		#region Propiedades
		public Int16? Id;
public String Nombre;

		#endregion 
		
		#region Construtores
		public clsParametro(){
			
		}

		~clsParametro(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,Nombre,
		}
		#endregion 

	}//end clsParametro

}//end namespace SAFCore