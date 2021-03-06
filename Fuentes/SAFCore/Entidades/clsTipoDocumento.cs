///////////////////////////////////////////////////////////
//  clsTipoDocumento.cs
//  Implementation of the Class clsTipoDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsTipoDocumento {

		#region Propiedades
		public Byte? Id;
public String Nombre;
public Int64? Consecutivo;
public Boolean Activo;
public String Operacion;

		#endregion 
		
		#region Construtores
		public clsTipoDocumento(){
			
		}

		~clsTipoDocumento(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,Nombre,Consecutivo,Activo,Operacion,
		}
		#endregion 

	}//end clsTipoDocumento

}//end namespace SAFCore