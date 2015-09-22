///////////////////////////////////////////////////////////
//  clsDevolucion.cs
//  Implementation of the Class clsDevolucion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDevolucion {

		#region Propiedades
		private Int32? m_id;
private Int16? m_idproyecto;
private Int16? m_idconductor;
private Int32? m_numero;
private String m_fechaanunciada;
private String m_fecharecogida;
private DateTime m_fechacreacion;
private Boolean m_entregacliente;
private Boolean m_entregaparcial;
private Byte m_tipomantenimiento;
private String m_hora;
private Boolean m_anulado;
private Decimal m_valortransporte;
private Decimal m_pesoequipo;
private Decimal m_valorequipo;

		#endregion 
		
		#region Construtores
		public clsDevolucion(){
			
		}

		~clsDevolucion(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idProyecto { 
 get {return m_idproyecto;} 
 set {m_idproyecto = value;} }public Int16? idConductor { 
 get {return m_idconductor;} 
 set {m_idconductor = value;} }public Int32? Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }public String FechaAnunciada { 
 get {return m_fechaanunciada;} 
 set {m_fechaanunciada = value;} }public String FechaRecogida { 
 get {return m_fecharecogida;} 
 set {m_fecharecogida = value;} }public DateTime FechaCreacion { 
 get {return m_fechacreacion;} 
 set {m_fechacreacion = value;} }public Boolean EntregaCliente { 
 get {return m_entregacliente;} 
 set {m_entregacliente = value;} }public Boolean EntregaParcial { 
 get {return m_entregaparcial;} 
 set {m_entregaparcial = value;} }public Byte TipoMantenimiento { 
 get {return m_tipomantenimiento;} 
 set {m_tipomantenimiento = value;} }public String Hora { 
 get {return m_hora;} 
 set {m_hora = value;} }public Boolean Anulado { 
 get {return m_anulado;} 
 set {m_anulado = value;} }public Decimal ValorTransporte { 
 get {return m_valortransporte;} 
 set {m_valortransporte = value;} }public Decimal PesoEquipo { 
 get {return m_pesoequipo;} 
 set {m_pesoequipo = value;} }public Decimal ValorEquipo { 
 get {return m_valorequipo;} 
 set {m_valorequipo = value;} }

		public enum Campos
		{
			id,idproyecto,idconductor,numero,fechaanunciada,fecharecogida,fechacreacion,entregacliente,entregaparcial,tipomantenimiento,hora,anulado,valortransporte,pesoequipo,valorequipo,
		}
		#endregion 

	}//end clsDevolucion

}//end namespace SAFCore