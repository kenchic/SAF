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
			private Byte m_id;
private String m_nombre;
private Boolean m_activo;
private String m_operacion;

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
		public Byte Id { 
 get {return m_id;} 
 set {m_id = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }public String Operacion { 
 get {return m_operacion;} 
 set {m_operacion = value;} }

		public enum Campos
		{
			id,nombre,activo,operacion,
		}
		#endregion 

	}//end clsTipoDocumento

}//end namespace SAFCore