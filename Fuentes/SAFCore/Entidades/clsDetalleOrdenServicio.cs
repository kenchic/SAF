///////////////////////////////////////////////////////////
//  clsDetalleOrdenServicio.cs
//  Implementation of the Class clsDetalleOrdenServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using SAFCore;
using System;

namespace SAFCore {
	public class clsDetalleOrdenServicio {

		#region Propiedades
		private Int32 m_id;
private Int32 m_idordenservicio;
private Int16 m_idelemento;
private Int32 m_cantidad;

       		#endregion 
		
		#region Construtores
		public clsDetalleOrdenServicio(){

		}

		~clsDetalleOrdenServicio(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32 idOrdenServicio { 
 get {return m_idordenservicio;} 
 set {m_idordenservicio = value;} }public Int16 idElemento { 
 get {return m_idelemento;} 
 set {m_idelemento = value;} }public Int32 Cantidad { 
 get {return m_cantidad;} 
 set {m_cantidad = value;} }
		#endregion 

	}//end clsDetalleOrdenServicio

}//end namespace SAFCore