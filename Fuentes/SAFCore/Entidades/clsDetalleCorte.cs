///////////////////////////////////////////////////////////
//  clsDetalleCorte.cs
//  Implementation of the Class clsDetalleCorte
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using SAFCore;
using System;

namespace SAFCore {
	public class clsDetalleCorte {

		#region Propiedades
		private Int32 m_id;
private Int32 m_idcorte;
private Int16 m_idelemento;
private Int32 m_idremision;
private Int16 m_idproveedor;
private Int32 m_cantidad;

       		#endregion 
		
		#region Construtores
		public clsDetalleCorte(){

		}

		~clsDetalleCorte(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32 idCorte { 
 get {return m_idcorte;} 
 set {m_idcorte = value;} }public Int16 idElemento { 
 get {return m_idelemento;} 
 set {m_idelemento = value;} }public Int32 idRemision { 
 get {return m_idremision;} 
 set {m_idremision = value;} }public Int16 idProveedor { 
 get {return m_idproveedor;} 
 set {m_idproveedor = value;} }public Int32 Cantidad { 
 get {return m_cantidad;} 
 set {m_cantidad = value;} }
		#endregion 

	}//end clsDetalleCorte

}//end namespace SAFCore