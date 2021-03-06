///////////////////////////////////////////////////////////
//  clsProveedor.cs
//  Implementation of the Class clsProveedor
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsProveedor {

		#region Propiedades
		public Int16? Id;
public String Identificacion;
public String Nombre;
public String Iniciales;
public String Telefono;
public String Direccion;
public Boolean Activo;

		#endregion 
		
		#region Construtores
		public clsProveedor(){
			
		}

		~clsProveedor(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,Identificacion,Nombre,Iniciales,Telefono,Direccion,Activo,
		}
		#endregion 

	}//end clsProveedor

}//end namespace SAFCore