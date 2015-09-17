///////////////////////////////////////////////////////////
//  clsMovimientoBodega.cs
//  Implementation of the Class clsMovimientoBodega
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsMovimientoBodega {

		#region Propiedades
			private Int32 m_id;
private Int16 m_idelemeto;
private Byte m_idbodegaorigen;
private Byte m_idbodegadestino;
private String m_documento;
private String m_numero;
private String m_operacion;
private Int32 m_cantidad;

		#endregion 
		
		#region Construtores
		public clsMovimientoBodega(){

		}

		~clsMovimientoBodega(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16 idElemeto { 
 get {return m_idelemeto;} 
 set {m_idelemeto = value;} }public Byte idBodegaOrigen { 
 get {return m_idbodegaorigen;} 
 set {m_idbodegaorigen = value;} }public Byte idBodegaDestino { 
 get {return m_idbodegadestino;} 
 set {m_idbodegadestino = value;} }public String Documento { 
 get {return m_documento;} 
 set {m_documento = value;} }public String Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }public String Operacion { 
 get {return m_operacion;} 
 set {m_operacion = value;} }public Int32 Cantidad { 
 get {return m_cantidad;} 
 set {m_cantidad = value;} }

		public enum Campos
		{
			id,idelemeto,idbodegaorigen,idbodegadestino,documento,numero,operacion,cantidad,
		}
		#endregion 

	}//end clsMovimientoBodega

}//end namespace SAFCore