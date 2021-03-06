///////////////////////////////////////////////////////////
//  clsAuditoria.cs
//  Implementation of the Class clsAuditoria
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsAuditoria {

		#region Propiedades
		private Int32? m_id;
private Int16? m_idusuario;
private Int16? m_ideventosauditoria;
private DateTime m_fecha;
private String m_ipterminal;
private String m_seccion;
private String m_titulo;
private String m_detalle;

		#endregion 
		
		#region Construtores
		public clsAuditoria(){
			
		}

		~clsAuditoria(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idUsuario { 
 get {return m_idusuario;} 
 set {m_idusuario = value;} }public Int16? idEventosAuditoria { 
 get {return m_ideventosauditoria;} 
 set {m_ideventosauditoria = value;} }public DateTime Fecha { 
 get {return m_fecha;} 
 set {m_fecha = value;} }public String IpTerminal { 
 get {return m_ipterminal;} 
 set {m_ipterminal = value;} }public String Seccion { 
 get {return m_seccion;} 
 set {m_seccion = value;} }public String Titulo { 
 get {return m_titulo;} 
 set {m_titulo = value;} }public String Detalle { 
 get {return m_detalle;} 
 set {m_detalle = value;} }

		public enum Campos
		{
			id,idusuario,ideventosauditoria,fecha,ipterminal,seccion,titulo,detalle,
		}
		#endregion 

	}//end clsAuditoria

}//end namespace SAFCore