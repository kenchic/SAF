///////////////////////////////////////////////////////////
//  clsReposicion.cs
//  Implementation of the Class clsReposicion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsReposicion {

		#region Propiedades
		public Int32? Id;
public Int32? idDevolucion;
public Int32? Numero;

		#endregion 
		
		#region Construtores
		public clsReposicion(){
			
		}

		~clsReposicion(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idDevolucion,Numero,
		}
		#endregion 

	}//end clsReposicion

}//end namespace SAFCore