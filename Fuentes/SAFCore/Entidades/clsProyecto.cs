///////////////////////////////////////////////////////////
//  clsProyecto.cs
//  Implementation of the Class clsProyecto
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsProyecto {

		#region Propiedades
		private Int16? m_id;
private Int32? m_idcliente;
private Int16? m_idciudad;
private String m_nombrecliente;
private String m_nombreciudad;
private String m_nombre;
private String m_tipo;
private String m_direccion;
private String m_telefono;
private String m_observacion;
private String m_fecha;
private String m_formacontacto;
private String m_sistemamedida;
private String m_identificacionresponsable;
private String m_nombreresponsable;
private String m_telresponsable;
private Boolean m_activo;
private Byte? m_estado;

		#endregion 
		
		#region Construtores
		public clsProyecto(){
			
		}

		~clsProyecto(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32? idCliente { 
 get {return m_idcliente;} 
 set {m_idcliente = value;} }public Int16? idCiudad { 
 get {return m_idciudad;} 
 set {m_idciudad = value;} }public String NombreCliente { 
 get {return m_nombrecliente;} 
 set {m_nombrecliente = value;} }public String NombreCiudad { 
 get {return m_nombreciudad;} 
 set {m_nombreciudad = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public String Tipo { 
 get {return m_tipo;} 
 set {m_tipo = value;} }public String Direccion { 
 get {return m_direccion;} 
 set {m_direccion = value;} }public String Telefono { 
 get {return m_telefono;} 
 set {m_telefono = value;} }public String Observacion { 
 get {return m_observacion;} 
 set {m_observacion = value;} }public String Fecha { 
 get {return m_fecha;} 
 set {m_fecha = value;} }public String FormaContacto { 
 get {return m_formacontacto;} 
 set {m_formacontacto = value;} }public String SistemaMedida { 
 get {return m_sistemamedida;} 
 set {m_sistemamedida = value;} }public String IdentificacionResponsable { 
 get {return m_identificacionresponsable;} 
 set {m_identificacionresponsable = value;} }public String NombreResponsable { 
 get {return m_nombreresponsable;} 
 set {m_nombreresponsable = value;} }public String TelResponsable { 
 get {return m_telresponsable;} 
 set {m_telresponsable = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }public Byte? Estado { 
 get {return m_estado;} 
 set {m_estado = value;} }

		public enum Campos
		{
			Id,idCliente,idCiudad,NombreCliente,NombreCiudad,Nombre,Tipo,Direccion,Telefono,Observacion,Fecha,FormaContacto,SistemaMedida,IdentificacionResponsable,NombreResponsable,TelResponsable,Activo,Estado,
		}
		#endregion 

	}//end clsProyecto

}//end namespace SAFCore