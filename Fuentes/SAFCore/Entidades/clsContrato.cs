///////////////////////////////////////////////////////////
//  clsContrato.cs
//  Implementation of the Class clsContrato
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsContrato {

		#region Propiedades
		private Int16? m_id;
private Byte m_idlistaprecios;
private Int16? m_idagente;
private Boolean m_informacionbd;
private Boolean m_contratoalquiler;
private Boolean m_cartapagare;
private Boolean m_pagare;
private Boolean m_letracambio;
private Boolean m_garantiascondiciones;
private Boolean m_deposito;
private Boolean m_anticipo;
private Boolean m_personajuridica;
private Boolean m_personanatural;
private Boolean m_fotocopiacedula;
private Boolean m_fotocopianit;
private Boolean m_camaracomercio;
private Byte m_descuentoalquiler;
private Byte m_descuentoventa;
private Byte m_descuentoreposicion;
private Byte m_descuentomantenimiento;
private Byte m_descuentotransporte;
private Byte m_porcentajeagente;

		#endregion 
		
		#region Construtores
		public clsContrato(){
			
		}

		~clsContrato(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Byte idListaPrecios { 
 get {return m_idlistaprecios;} 
 set {m_idlistaprecios = value;} }public Int16? idAgente { 
 get {return m_idagente;} 
 set {m_idagente = value;} }public Boolean InformacionBD { 
 get {return m_informacionbd;} 
 set {m_informacionbd = value;} }public Boolean ContratoAlquiler { 
 get {return m_contratoalquiler;} 
 set {m_contratoalquiler = value;} }public Boolean CartaPagare { 
 get {return m_cartapagare;} 
 set {m_cartapagare = value;} }public Boolean Pagare { 
 get {return m_pagare;} 
 set {m_pagare = value;} }public Boolean LetraCambio { 
 get {return m_letracambio;} 
 set {m_letracambio = value;} }public Boolean GarantiasCondiciones { 
 get {return m_garantiascondiciones;} 
 set {m_garantiascondiciones = value;} }public Boolean Deposito { 
 get {return m_deposito;} 
 set {m_deposito = value;} }public Boolean Anticipo { 
 get {return m_anticipo;} 
 set {m_anticipo = value;} }public Boolean PersonaJuridica { 
 get {return m_personajuridica;} 
 set {m_personajuridica = value;} }public Boolean PersonaNatural { 
 get {return m_personanatural;} 
 set {m_personanatural = value;} }public Boolean FotoCopiaCedula { 
 get {return m_fotocopiacedula;} 
 set {m_fotocopiacedula = value;} }public Boolean FotoCopiaNit { 
 get {return m_fotocopianit;} 
 set {m_fotocopianit = value;} }public Boolean CamaraComercio { 
 get {return m_camaracomercio;} 
 set {m_camaracomercio = value;} }public Byte DescuentoAlquiler { 
 get {return m_descuentoalquiler;} 
 set {m_descuentoalquiler = value;} }public Byte DescuentoVenta { 
 get {return m_descuentoventa;} 
 set {m_descuentoventa = value;} }public Byte DescuentoReposicion { 
 get {return m_descuentoreposicion;} 
 set {m_descuentoreposicion = value;} }public Byte DescuentoMantenimiento { 
 get {return m_descuentomantenimiento;} 
 set {m_descuentomantenimiento = value;} }public Byte DescuentoTransporte { 
 get {return m_descuentotransporte;} 
 set {m_descuentotransporte = value;} }public Byte PorcentajeAgente { 
 get {return m_porcentajeagente;} 
 set {m_porcentajeagente = value;} }

		public enum Campos
		{
			id,idlistaprecios,idagente,informacionbd,contratoalquiler,cartapagare,pagare,letracambio,garantiascondiciones,deposito,anticipo,personajuridica,personanatural,fotocopiacedula,fotocopianit,camaracomercio,descuentoalquiler,descuentoventa,descuentoreposicion,descuentomantenimiento,descuentotransporte,porcentajeagente,
		}
		#endregion 

	}//end clsContrato

}//end namespace SAFCore