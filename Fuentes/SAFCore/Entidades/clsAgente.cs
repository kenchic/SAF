///////////////////////////////////////////////////////////
//  clsAgente.cs
//  Implementation of the Class clsAgente
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsAgente {

		#region Propiedades
		public Int16? Id;
public String Nombre;
public Boolean Activo;

		#endregion 
		
		#region Construtores
		public clsAgente(){
			
		}

		~clsAgente(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,Nombre,Activo,
		}
		#endregion 

	}//end clsAgente

}//end namespace SAFCore