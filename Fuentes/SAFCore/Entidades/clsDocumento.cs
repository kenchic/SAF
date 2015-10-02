///////////////////////////////////////////////////////////
//  clsDocumento.cs
//  Implementation of the Class clsDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDocumento {

		#region Propiedades
		private Int32? m_id;
private Byte? m_idtipodocumento;
private String m_fecha;
private String m_descripcion;
private Boolean m_anulado;

		#endregion 
		
		#region Construtores
		public clsDocumento(){
			
		}

		~clsDocumento(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Byte? idTipoDocumento { 
 get {return m_idtipodocumento;} 
 set {m_idtipodocumento = value;} }public String Fecha { 
 get {return m_fecha;} 
 set {m_fecha = value;} }public String Descripcion { 
 get {return m_descripcion;} 
 set {m_descripcion = value;} }public Boolean Anulado { 
 get {return m_anulado;} 
 set {m_anulado = value;} }

		public enum Campos
		{
			Id,idTipoDocumento,Fecha,Descripcion,Anulado,
		}
		#endregion 

	}//end clsDocumento

}//end namespace SAFCore