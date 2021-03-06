///////////////////////////////////////////////////////////
//  clsPrivilegioRol.cs
//  Implementation of the Class clsPrivilegioRol
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsPrivilegioRol {

		#region Propiedades
		private Int32? m_id;
private Int16? m_idrol;
private Int16? m_idprivilegio;
private Int16? m_valor;
private Boolean m_activo;

		#endregion 
		
		#region Construtores
		public clsPrivilegioRol(){
			
		}

		~clsPrivilegioRol(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idRol { 
 get {return m_idrol;} 
 set {m_idrol = value;} }public Int16? idPrivilegio { 
 get {return m_idprivilegio;} 
 set {m_idprivilegio = value;} }public Int16? Valor { 
 get {return m_valor;} 
 set {m_valor = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }

		public enum Campos
		{
			id,idrol,idprivilegio,valor,activo,
		}
		#endregion 

	}//end clsPrivilegioRol

}//end namespace SAFCore