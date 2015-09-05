///////////////////////////////////////////////////////////
//  clsRemision.cs
//  Implementation of the Class clsRemision
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using SAFCore;
using System;

namespace SAFCore {
	public class clsRemision {

		#region Propiedades
		private Int32 m_id;
private Int16 m_idproyectoalquiler;
private Int16 m_idproyectoventa;
private Int16 m_idconductor;
private Int32 m_numero;
private String m_fechapedido;
private String m_fechaentrega;
private DateTime m_fechacreacion;
private String m_hora;
private Boolean m_anulado;
private Boolean m_transporte;
private Decimal m_valortransporte;
private Boolean m_despachado;
private Boolean m_equipoadecuado;
private Decimal m_pesoequipo;
private Decimal m_valorequipo;

       		#endregion 
		
		#region Construtores
		public clsRemision(){

		}

		~clsRemision(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16 idProyectoAlquiler { 
 get {return m_idproyectoalquiler;} 
 set {m_idproyectoalquiler = value;} }public Int16 idProyectoVenta { 
 get {return m_idproyectoventa;} 
 set {m_idproyectoventa = value;} }public Int16 idConductor { 
 get {return m_idconductor;} 
 set {m_idconductor = value;} }public Int32 Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }public String FechaPedido { 
 get {return m_fechapedido;} 
 set {m_fechapedido = value;} }public String FechaEntrega { 
 get {return m_fechaentrega;} 
 set {m_fechaentrega = value;} }public DateTime FechaCreacion { 
 get {return m_fechacreacion;} 
 set {m_fechacreacion = value;} }public String Hora { 
 get {return m_hora;} 
 set {m_hora = value;} }public Boolean Anulado { 
 get {return m_anulado;} 
 set {m_anulado = value;} }public Boolean Transporte { 
 get {return m_transporte;} 
 set {m_transporte = value;} }public Decimal ValorTransporte { 
 get {return m_valortransporte;} 
 set {m_valortransporte = value;} }public Boolean Despachado { 
 get {return m_despachado;} 
 set {m_despachado = value;} }public Boolean EquipoAdecuado { 
 get {return m_equipoadecuado;} 
 set {m_equipoadecuado = value;} }public Decimal PesoEquipo { 
 get {return m_pesoequipo;} 
 set {m_pesoequipo = value;} }public Decimal ValorEquipo { 
 get {return m_valorequipo;} 
 set {m_valorequipo = value;} }
		#endregion 

	}//end clsRemision

}//end namespace SAFCore