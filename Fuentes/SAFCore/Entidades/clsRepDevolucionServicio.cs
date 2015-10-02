///////////////////////////////////////////////////////////
//  clsRepDevolucionServicio.cs
//  Implementation of the Class clsRepDevolucionServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsRepDevolucionServicio {

		#region Propiedades
		private Int32? m_id;
private Int32? m_iddevolucion;
private Int32? m_numero;

		#endregion 
		
		#region Construtores
		public clsRepDevolucionServicio(){
			
		}

		~clsRepDevolucionServicio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32? idDevolucion { 
 get {return m_iddevolucion;} 
 set {m_iddevolucion = value;} }public Int32? Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }

		public enum Campos
		{
			Id,idDevolucion,Numero,
		}
		#endregion 

	}//end clsRepDevolucionServicio

}//end namespace SAFCore