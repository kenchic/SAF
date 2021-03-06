///////////////////////////////////////////////////////////
//  clsParametroSistema.cs
//  Implementation of the Class clsParametroSistema
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFseg {
	public class clsParametroSistema {

		#region Propiedades
		private String m_codigo;
private Int16? m_idparametro;
private String m_valor;

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
		public String Codigo { 
 get {return m_codigo;} 
 set {m_codigo = value;} }public Int16? idParametro { 
 get {return m_idparametro;} 
 set {m_idparametro = value;} }public String Valor { 
 get {return m_valor;} 
 set {m_valor = value;} }

		public enum Campos
		{
			codigo,idparametro,valor,
		}
		#endregion 

	}//end clsParametroSistema

}//end namespace SAFCore