///////////////////////////////////////////////////////////
//  clsProyectoVenta.cs
//  Implementation of the Class clsProyectoVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsProyectoVenta {

		#region Propiedades
		public Int16? Id;
public Int16? idProyecto;

		#endregion 
		
		#region Construtores
		public clsProyectoVenta(){
			
		}

		~clsProyectoVenta(){
			
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

	}//end clsProyectoVenta

}//end namespace SAFCore