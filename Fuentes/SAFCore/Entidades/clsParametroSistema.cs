///////////////////////////////////////////////////////////
//  clsParametroSistema.cs
//  Implementation of the Class clsParametroSistema
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsParametroSistema {

		#region Propiedades
		public String Codigo;
public Int16? idParametro;
public String Valor;

		#endregion 
		
		#region Construtores
		public clsParametroSistema(){
			
		}

		~clsParametroSistema(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Codigo,idParametro,Valor,
		}
		#endregion 

	}//end clsParametroSistema

}//end namespace SAFCore