///////////////////////////////////////////////////////////
//  clsReposicion.cs
//  Implementation of the Class clsReposicion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using SAFCore;
using System;

namespace SAFCore {
	public class clsReposicion {

		#region Propiedades
		private Int32 m_id;
private Int32 m_iddevolucion;
private Int32 m_numero;

       		#endregion 
		
		#region Construtores
		public clsReposicion(){

		}

		~clsReposicion(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32 idDevolucion { 
 get {return m_iddevolucion;} 
 set {m_iddevolucion = value;} }public Int32 Numero { 
 get {return m_numero;} 
 set {m_numero = value;} }
		#endregion 

	}//end clsReposicion

}//end namespace SAFCore