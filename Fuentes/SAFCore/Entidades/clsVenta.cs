///////////////////////////////////////////////////////////
//  clsVenta.cs
//  Implementation of the Class clsVenta
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsVenta {

		#region Propiedades
		private Int32? m_id;
private Int32? m_idremision;
private Int32? m_numero;

		#endregion 
		
		#region Construtores
		public clsVenta(){
			
		}

		~clsVenta(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32? idRemision { 
 get {return m_idremision;} 
 set {m_idremision = value;} }public Int32? Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }

		public enum Campos
		{
			id,idremision,numero,
		}
		#endregion 

	}//end clsVenta

}//end namespace SAFCore