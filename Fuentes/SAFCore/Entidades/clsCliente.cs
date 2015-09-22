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
		private Int32? m_id;
private Int16? m_idciudad;
private String m_identificacion;
private String m_nombre1;
private String m_nombre2;
private String m_apellido1;
private String m_apellido2;
private String m_nombre;
private String m_direccion;
private String m_telefono;
private String m_celular;
private String m_correo;
private Boolean m_activo;

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
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idCiudad { 
 get {return m_idciudad;} 
 set {m_idciudad = value;} }public String Identificacion { 
 get {return m_identificacion;} 
 set {m_identificacion = value;} }public String Nombre1 { 
 get {return m_nombre1;} 
 set {m_nombre1 = value;} }public String Nombre2 { 
 get {return m_nombre2;} 
 set {m_nombre2 = value;} }public String Apellido1 { 
 get {return m_apellido1;} 
 set {m_apellido1 = value;} }public String Apellido2 { 
 get {return m_apellido2;} 
 set {m_apellido2 = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public String Direccion { 
 get {return m_direccion;} 
 set {m_direccion = value;} }public String Telefono { 
 get {return m_telefono;} 
 set {m_telefono = value;} }public String Celular { 
 get {return m_celular;} 
 set {m_celular = value;} }public String Correo { 
 get {return m_correo;} 
 set {m_correo = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }

		public enum Campos
		{
			id,idciudad,identificacion,nombre1,nombre2,apellido1,apellido2,nombre,direccion,telefono,celular,correo,activo,
		}
		#endregion 

	}//end clsCliente

}//end namespace SAFCore