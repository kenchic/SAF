///////////////////////////////////////////////////////////
//  clsDetalleDevolucion.cs
//  Implementation of the Class clsDetalleDevolucion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleDevolucion {

		#region Propiedades
		private Int32? m_id;
private Int32? m_iddevolucion;
private Int16? m_idelemento;
private Int32? m_cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleDevolucion(){
			
		}

		~clsDetalleDevolucion(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32? idDevolucion { 
 get {return m_iddevolucion;} 
 set {m_iddevolucion = value;} }public Int16? idElemento { 
 get {return m_idelemento;} 
 set {m_idelemento = value;} }public Int32? Cantidad { 
 get {return m_cantidad;} 
 set {m_cantidad = value;} }

		public enum Campos
		{
			Id,idDevolucion,idElemento,Cantidad,
		}
		#endregion 

	}//end clsDetalleDevolucion

}//end namespace SAFCore