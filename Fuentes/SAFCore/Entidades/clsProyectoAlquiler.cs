///////////////////////////////////////////////////////////
//  clsProyectoAlquiler.cs
//  Implementation of the Class clsProyectoAlquiler
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsProyectoAlquiler {

		#region Propiedades
		private Int16? m_id;
private Int16? m_idproyecto;

		#endregion 
		
		#region Construtores
		public clsProyectoAlquiler(){
			
		}

		~clsProyectoAlquiler(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		public Int16? Id { 
 get {return m_id;} 
 set {m_id = value;} }public Int16? idProyecto { 
 get {return m_idproyecto;} 
 set {m_idproyecto = value;} }

		public enum Campos
		{
			Id,idProyecto,
		}
		#endregion 

	}//end clsProyectoAlquiler

}//end namespace SAFCore