///////////////////////////////////////////////////////////
//  clsUsuario.cs
//  Implementation of the Class clsUsuario
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsUsuario {

		#region Propiedades
		private Int16? m_id;
private Int16? m_idrol;
private String m_identificacion;
private String m_nombre;
private String m_apellido;
private String m_usuario;
private String m_clave;
private String m_correo;
private Boolean m_activo;
private Boolean m_admin;

		#endregion 
		
		#region Construtores
		public clsUsuario(){
			
		}

		~clsUsuario(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idRol { 
 get {return m_idrol;} 
 set {m_idrol = value;} }public String Identificacion { 
 get {return m_identificacion;} 
 set {m_identificacion = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public String Apellido { 
 get {return m_apellido;} 
 set {m_apellido = value;} }public String Usuario { 
 get {return m_usuario;} 
 set {m_usuario = value;} }public String Clave { 
 get {return m_clave;} 
 set {m_clave = value;} }public String Correo { 
 get {return m_correo;} 
 set {m_correo = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }public Boolean Admin { 
 get {return m_admin;} 
 set {m_admin = value;} }

		public enum Campos
		{
			id,idrol,identificacion,nombre,apellido,usuario,clave,correo,activo,admin,
		}
		#endregion 

	}//end clsUsuario

}//end namespace SAFCore