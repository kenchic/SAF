///////////////////////////////////////////////////////////
//  clsUnidadMedida.cs
//  Implementation of the Class clsUnidadMedida
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsUnidadMedida {

		#region Propiedades
		public Byte? Id;
public String Nombre;
public Boolean Activo;

		#endregion 
		
		#region Construtores
		public clsUnidadMedida(){
			
		}

		~clsUnidadMedida(){
			
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

	}//end clsUnidadMedida

}//end namespace SAFCore