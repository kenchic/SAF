///////////////////////////////////////////////////////////
//  clsDetalleReposicion.cs
//  Implementation of the Class clsDetalleReposicion
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsDetalleReposicion {

		#region Propiedades
		public Int32? Id;
public Int32? idReposicion;
public Int16? idElemento;
public Int32? Cantidad;

		#endregion 
		
		#region Construtores
		public clsDetalleReposicion(){
			
		}

		~clsDetalleReposicion(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idReposicion,idElemento,Cantidad,
		}
		#endregion 

	}//end clsDetalleReposicion

}//end namespace SAFCore