///////////////////////////////////////////////////////////
//  clsCorte.cs
//  Implementation of the Class clsCorte
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsCorte {

		#region Propiedades
		private Int32? m_id;
private Int16? m_idproyectoventa;
private Int16? m_idproyectoalquiler;
private Int32? m_numero;
private String m_fecha;

		#endregion 
		
		#region Construtores
		public clsCorte(){
			
		}

		~clsCorte(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idProyectoVenta { 
 get {return m_idproyectoventa;} 
 set {m_idproyectoventa = value;} }public Int16? idProyectoAlquiler { 
 get {return m_idproyectoalquiler;} 
 set {m_idproyectoalquiler = value;} }public Int32? Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }public String Fecha { 
 get {return m_fecha;} 
 set {m_fecha = value;} }

		public enum Campos
		{
			Id,idProyectoVenta,idProyectoAlquiler,Numero,Fecha,
		}
		#endregion 

	}//end clsCorte

}//end namespace SAFCore