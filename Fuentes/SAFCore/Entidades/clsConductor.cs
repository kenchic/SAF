///////////////////////////////////////////////////////////
//  clsConductor.cs
//  Implementation of the Class clsConductor
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsConductor {

		#region Propiedades
		public Int16? Id;
public String Nombre;
public Boolean Activo;
public String Placa;

		#endregion 
		
		#region Construtores
		public clsConductor(){
			
		}

		~clsConductor(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,Nombre,Activo,Placa,
		}
		#endregion 

	}//end clsConductor

}//end namespace SAFCore