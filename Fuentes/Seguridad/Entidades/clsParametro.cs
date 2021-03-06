///////////////////////////////////////////////////////////
//  clsParametro.cs
//  Implementation of the Class clsParametro
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsParametro {

		#region Propiedades
		private Int16? m_id;
private String m_nombre;

		#endregion 
		
		#region Construtores
		public clsParametro(){
			
		}

		~clsParametro(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16? Id { 
 get {return m_id;} 
 set {m_id = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }

		public enum Campos
		{
			id,nombre,
		}
		#endregion 

	}//end clsParametro

}//end namespace SAFCore