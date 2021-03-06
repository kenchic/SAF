///////////////////////////////////////////////////////////
//  clsMenuRol.cs
//  Implementation of the Class clsMenuRol
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsMenuRol {

		#region Propiedades
		private Int32? m_id;
private Int32? m_idmenu;
private Int16? m_idrol;

		#endregion 
		
		#region Construtores
		public clsMenuRol(){
			
		}

		~clsMenuRol(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32? idMenu { 
 get {return m_idmenu;} 
 set {m_idmenu = value;} }public Int16? idRol { 
 get {return m_idrol;} 
 set {m_idrol = value;} }

		public enum Campos
		{
			id,idmenu,idrol,
		}
		#endregion 

	}//end clsMenuRol

}//end namespace SAFCore