///////////////////////////////////////////////////////////
//  clsConductor.cs
//  Implementation of the Class clsConductor
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsConductor {

		#region Propiedades
		private Int16? m_id;
private String m_nombre;
private Boolean m_activo;
private String m_placa;

		#endregion 
		
		#region Construtores
		public clsConductor(){
			
		}

		~clsConductor(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16? Id { 
 get {return m_id;} 
 set {m_id = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }public String Placa { 
 get {return m_placa;} 
 set {m_placa = value;} }

		public enum Campos
		{
			Id,Nombre,Activo,Placa,
		}
		#endregion 

	}//end clsConductor

}//end namespace SAFCore