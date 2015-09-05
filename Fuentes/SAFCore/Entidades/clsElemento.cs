///////////////////////////////////////////////////////////
//  clsElemento.cs
//  Implementation of the Class clsElemento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using SAFCore;
using System;

namespace SAFCore {
	public class clsElemento {

		#region Propiedades
		private Int16 m_id;
private Byte m_idgruposelemento;
private Byte m_idunidadmedida;
private String m_referencia;
private String m_nombre;
private Double m_mt2;
private Double m_peso;
private Boolean m_rotacion;
private Boolean m_activo;

       		#endregion 
		
		#region Construtores
		public clsElemento(){

		}

		~clsElemento(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Byte idGruposElemento { 
 get {return m_idgruposelemento;} 
 set {m_idgruposelemento = value;} }public Byte idUnidadMedida { 
 get {return m_idunidadmedida;} 
 set {m_idunidadmedida = value;} }public String Referencia { 
 get {return m_referencia;} 
 set {m_referencia = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public Double Mt2 { 
 get {return m_mt2;} 
 set {m_mt2 = value;} }public Double Peso { 
 get {return m_peso;} 
 set {m_peso = value;} }public Boolean Rotacion { 
 get {return m_rotacion;} 
 set {m_rotacion = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }
		#endregion 

	}//end clsElemento

}//end namespace SAFCore