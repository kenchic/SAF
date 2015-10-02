///////////////////////////////////////////////////////////
//  clsDetalleListaPrecio.cs
//  Implementation of the Class clsDetalleListaPrecio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleListaPrecio {

		#region Propiedades
		private Int32? m_id;
private Byte? m_idlistaprecios;
private Int16? m_idelemento;
private Int32? m_precioalquiler;
private Int32? m_precioventa;
private Int32? m_precioperdida;

		#endregion 
		
		#region Construtores
		public clsDetalleListaPrecio(){
			
		}

		~clsDetalleListaPrecio(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Byte? idListaPrecios { 
 get {return m_idlistaprecios;} 
 set {m_idlistaprecios = value;} }public Int16? idElemento { 
 get {return m_idelemento;} 
 set {m_idelemento = value;} }public Int32? PrecioAlquiler { 
 get {return m_precioalquiler;} 
 set {m_precioalquiler = value;} }public Int32? PrecioVenta { 
 get {return m_precioventa;} 
 set {m_precioventa = value;} }public Int32? PrecioPerdida { 
 get {return m_precioperdida;} 
 set {m_precioperdida = value;} }

		public enum Campos
		{
			Id,idListaPrecios,idElemento,PrecioAlquiler,PrecioVenta,PrecioPerdida,
		}
		#endregion 

	}//end clsDetalleListaPrecio

}//end namespace SAFCore