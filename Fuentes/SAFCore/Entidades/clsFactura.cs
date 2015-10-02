///////////////////////////////////////////////////////////
//  clsFactura.cs
//  Implementation of the Class clsFactura
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsFactura {

		#region Propiedades
		private Int32? m_id;
private Int32? m_idcorte;
private Int32? m_numero;
private String m_fechaemision;
private String m_fechavencimiento;
private String m_son;
private Decimal m_parcialtotal;
private Byte? m_dcto;
private Decimal m_subtotal;
private Byte? m_iva;
private Decimal m_total;
private Boolean m_anulada;
private Byte? m_idtipofactura;

		#endregion 
		
		#region Construtores
		public clsFactura(){
			
		}

		~clsFactura(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32? idCorte { 
 get {return m_idcorte;} 
 set {m_idcorte = value;} }public Int32? Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }public String FechaEmision { 
 get {return m_fechaemision;} 
 set {m_fechaemision = value;} }public String FechaVencimiento { 
 get {return m_fechavencimiento;} 
 set {m_fechavencimiento = value;} }public String Son { 
 get {return m_son;} 
 set {m_son = value;} }public Decimal ParcialTotal { 
 get {return m_parcialtotal;} 
 set {m_parcialtotal = value;} }public Byte? Dcto { 
 get {return m_dcto;} 
 set {m_dcto = value;} }public Decimal SubTotal { 
 get {return m_subtotal;} 
 set {m_subtotal = value;} }public Byte? Iva { 
 get {return m_iva;} 
 set {m_iva = value;} }public Decimal Total { 
 get {return m_total;} 
 set {m_total = value;} }public Boolean Anulada { 
 get {return m_anulada;} 
 set {m_anulada = value;} }public Byte? idTipoFactura { 
 get {return m_idtipofactura;} 
 set {m_idtipofactura = value;} }

		public enum Campos
		{
			Id,idCorte,Numero,FechaEmision,FechaVencimiento,Son,ParcialTotal,Dcto,SubTotal,Iva,Total,Anulada,idTipoFactura,
		}
		#endregion 

	}//end clsFactura

}//end namespace SAFCore