///////////////////////////////////////////////////////////
//  clsProyectoAlquiler.cs
//  Implementation of the Class clsProyectoAlquiler
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsProyectoAlquiler {

		#region Propiedades
		public Int16? Id;
public Int16? idProyecto;

		#endregion 
		
		#region Construtores
		public clsProyectoAlquiler(){
			
		}

		~clsProyectoAlquiler(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idProyecto,
		}
		#endregion 

	}//end clsProyectoAlquiler

}//end namespace SAFCore