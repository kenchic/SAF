///////////////////////////////////////////////////////////
//  clsPrivilegio.cs
//  Implementation of the Class clsPrivilegio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsPrivilegio {

		#region Propiedades
		private Int16? m_id;
private String m_nombre;
private Boolean m_activo;
private Int16? m_idprivilegiopadre;

		#endregion 
		
		#region Construtores
		public clsPrivilegio(){
			
		}

		~clsPrivilegio(){
			
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
 set {m_activo = value;} }public Int16? IdPrivilegioPadre { 
 get {return m_idprivilegiopadre;} 
 set {m_idprivilegiopadre = value;} }

		public enum Campos
		{
			id,nombre,activo,idprivilegiopadre,
		}
		#endregion 

	}//end clsPrivilegio

}//end namespace SAFCore