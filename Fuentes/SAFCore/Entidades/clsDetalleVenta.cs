///////////////////////////////////////////////////////////
//  clsDetalleVenta.cs
//  Implementation of the Class clsDetalleVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleVenta {

		#region Propiedades
		private Int32? m_id;
private Int16? m_idelemento;
private Int32? m_idventa;
private Int32? m_cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleVenta(){
			
		}

		~clsDetalleVenta(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idElemento { 
 get {return m_idelemento;} 
 set {m_idelemento = value;} }public Int32? idVenta { 
 get {return m_idventa;} 
 set {m_idventa = value;} }public Int32? Cantidad { 
 get {return m_cantidad;} 
 set {m_cantidad = value;} }

		public enum Campos
		{
			Id,idElemento,idVenta,Cantidad,
		}
		#endregion 

	}//end clsDetalleVenta

}//end namespace SAFCore