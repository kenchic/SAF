///////////////////////////////////////////////////////////
//  clsDetalleFactura.cs
//  Implementation of the Class clsDetalleFactura
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleFactura {

		#region Propiedades
		private Int32? m_id;
private Int16? m_idelemento;
private Int32? m_idfactura;
private String m_detalle;
private Byte? m_dias;
private Int32? m_cantidad;
private Int32? m_valor;

		#endregion 
		
		#region Construtores
		public clsDetalleFactura(){
			
		}

		~clsDetalleFactura(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idElemento { 
 get {return m_idelemento;} 
 set {m_idelemento = value;} }public Int32? idFactura { 
 get {return m_idfactura;} 
 set {m_idfactura = value;} }public String Detalle { 
 get {return m_detalle;} 
 set {m_detalle = value;} }public Byte? Dias { 
 get {return m_dias;} 
 set {m_dias = value;} }public Int32? Cantidad { 
 get {return m_cantidad;} 
 set {m_cantidad = value;} }public Int32? Valor { 
 get {return m_valor;} 
 set {m_valor = value;} }

		public enum Campos
		{
			Id,idElemento,idFactura,Detalle,Dias,Cantidad,Valor,
		}
		#endregion 

	}//end clsDetalleFactura

}//end namespace SAFCore