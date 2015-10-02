///////////////////////////////////////////////////////////
//  clsProveedor.cs
//  Implementation of the Class clsProveedor
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsProveedor {

		#region Propiedades
		private Int16? m_id;
private String m_identificacion;
private String m_nombre;
private String m_iniciales;
private String m_telefono;
private String m_direccion;
private Boolean m_activo;

		#endregion 
		
		#region Construtores
		public clsProveedor(){
			
		}

		~clsProveedor(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16? Id { 
 get {return m_id;} 
 set {m_id = value;} }public String Identificacion { 
 get {return m_identificacion;} 
 set {m_identificacion = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public String Iniciales { 
 get {return m_iniciales;} 
 set {m_iniciales = value;} }public String Telefono { 
 get {return m_telefono;} 
 set {m_telefono = value;} }public String Direccion { 
 get {return m_direccion;} 
 set {m_direccion = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }

		public enum Campos
		{
			Id,Identificacion,Nombre,Iniciales,Telefono,Direccion,Activo,
		}
		#endregion 

	}//end clsProveedor

}//end namespace SAFCore