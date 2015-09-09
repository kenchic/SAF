///////////////////////////////////////////////////////////
//  clsMenu.cs
//  Implementation of the Class clsMenu
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsMenu {

		#region Propiedades
			private Int32 m_id;
private Int32 m_idmenupadre;
private String m_nombre;
private String m_url;
private Int16 m_orden;
private Boolean m_activo;

		#endregion 
		
		#region Construtores
		public clsMenu(){

		}

		~clsMenu(){

		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int32 Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int32 idMenuPadre { 
 get {return m_idmenupadre;} 
 set {m_idmenupadre = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public String Url { 
 get {return m_url;} 
 set {m_url = value;} }public Int16 Orden { 
 get {return m_orden;} 
 set {m_orden = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }

		public enum Campos
		{
			id,idmenupadre,nombre,url,orden,activo,
		}
		#endregion 

	}//end clsMenu

}//end namespace SAFCore