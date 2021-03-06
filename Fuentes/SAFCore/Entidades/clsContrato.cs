///////////////////////////////////////////////////////////
//  clsContrato.cs
//  Implementation of the Class clsContrato
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore {
	public class clsContrato {

		#region Propiedades
		public Int16? Id;
public Byte? idListaPrecios;
public Int16? idAgente;
public Boolean InformacionBD;
public Boolean ContratoAlquiler;
public Boolean CartaPagare;
public Boolean Pagare;
public Boolean LetraCambio;
public Boolean GarantiasCondiciones;
public Boolean Deposito;
public Boolean Anticipo;
public Boolean PersonaJuridica;
public Boolean PersonaNatural;
public Boolean FotoCopiaCedula;
public Boolean FotoCopiaNit;
public Boolean CamaraComercio;
public Byte? DescuentoAlquiler;
public Byte? DescuentoVenta;
public Byte? DescuentoReposicion;
public Byte? DescuentoMantenimiento;
public Byte? DescuentoTransporte;
public Byte? PorcentajeAgente;

		#endregion 
		
		#region Construtores
		public clsContrato(){
			
		}

		~clsContrato(){
			
		}

		public void Dispose(bool disposing){

		}
		#endregion 
		
		#region Metodos
		

		public enum Campos
		{
			Id,idListaPrecios,idAgente,InformacionBD,ContratoAlquiler,CartaPagare,Pagare,LetraCambio,GarantiasCondiciones,Deposito,Anticipo,PersonaJuridica,PersonaNatural,FotoCopiaCedula,FotoCopiaNit,CamaraComercio,DescuentoAlquiler,DescuentoVenta,DescuentoReposicion,DescuentoMantenimiento,DescuentoTransporte,PorcentajeAgente,
		}
		#endregion 

	}//end clsContrato

}//end namespace SAFCore