///////////////////////////////////////////////////////////
//  clsEventoAuditoria.cs
//  Implementation of the Class clsEventoAuditoria
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsEventoAuditoria {

		#region Propiedades
		private Int16? m_id;
private String m_nombre;
private Boolean m_activo;

		#endregion 
		
		#region Construtores
		public clsEventoAuditoria(){
			
		}

		~clsEventoAuditoria(){
			
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
 set {m_activo = value;} }

		public enum Campos
		{
			id,nombre,activo,
		}
		#endregion 

	}//end clsEventoAuditoria

}//end namespace SAFCore