///////////////////////////////////////////////////////////
//  clsCliente.cs
//  Implementation of the Class clsCliente
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsCliente {

		#region Propiedades
		public Int32? Id;
public Int16? idCiudad;
public String Identificacion;
public String Nombre1;
public String Nombre2;
public String Apellido1;
public String Apellido2;
public String Nombre;
public String Direccion;
public String Telefono;
public String Celular;
public String Correo;
public Boolean Activo;

		#endregion 
		
		#region Construtores
		public clsCliente(){
			
		}

		~clsCliente(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idCiudad,Identificacion,Nombre1,Nombre2,Apellido1,Apellido2,Nombre,Direccion,Telefono,Celular,Correo,Activo,
		}
		#endregion 

	}//end clsCliente

}//end namespace SAFCore