///////////////////////////////////////////////////////////
//  clsOrdenServicio.cs
//  Implementation of the Class clsOrdenServicio
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using SAFCore;
using System;

namespace SAFCore {
	public class clsOrdenServicio {

		#region Propiedades
		private Int32 m_id;
private Int32 m_idremision;
private Int16 m_idproveedor;
private Int32 m_numero;

       		#endregion 
		
		#region Construtores
		public clsOrdenServicio(){

		}

		~clsOrdenServicio(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32 idRemision { 
 get {return m_idremision;} 
 set {m_idremision = value;} }public Int16 idProveedor { 
 get {return m_idproveedor;} 
 set {m_idproveedor = value;} }public Int32 Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }
		#endregion 

	}//end clsOrdenServicio

}//end namespace SAFCore