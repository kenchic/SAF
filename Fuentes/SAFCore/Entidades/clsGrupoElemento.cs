///////////////////////////////////////////////////////////
//  clsGrupoElemento.cs
//  Implementation of the Class clsGrupoElemento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsGrupoElemento {

		#region Propiedades
		public Byte? Id;
public String Nombre;
public Boolean Activo;

		#endregion 
		
		#region Construtores
		public clsGrupoElemento(){
			
		}

		~clsGrupoElemento(){
			
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

	}//end clsGrupoElemento

}//end namespace SAFCore