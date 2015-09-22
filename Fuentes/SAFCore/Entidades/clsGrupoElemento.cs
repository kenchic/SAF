///////////////////////////////////////////////////////////
//  clsGrupoElemento.cs
//  Implementation of the Class clsGrupoElemento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsGrupoElemento {

		#region Propiedades
		private Byte m_id;
private String m_nombre;
private Boolean m_activo;

		#endregion 
		
		#region Construtores
		public clsGrupoElemento(){
			
		}

		~clsGrupoElemento(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Byte Id { 
 get {return m_id;} 
 set {m_id = value;} }public String Nombre { 
 get {return m_nombre;} 
 set {m_nombre = value;} }public Boolean Activo { 
 get {return m_activo;} 
 set {m_activo = value;} }

		public enum Campos
		{
			id,nombre,activo,
		}
		#endregion 

	}//end clsGrupoElemento

}//end namespace SAFCore