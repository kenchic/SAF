///////////////////////////////////////////////////////////
//  clsDetalleDocumentoDALC.cs
//  Implementation of the Class DALC DetalleDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFCore {

    public partial class clsDetalleDocumentoDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsDetalleDocumento Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleDocumento fab = new clsFabricaDetalleDocumento();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsDetalleDocumento> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleDocumento fab = new clsFabricaDetalleDocumento();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdDetalleDocumento");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsDetalleDocumento obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsDetalleDocumento obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsDetalleDocumento obj)
        {
            int resultado=0;
	    return resultado;
	}

        public Comandos EjecutorBaseDatos{
            get{return m_ejecutor_base_datos;}
            set{m_ejecutor_base_datos = value;}
        }        

   }//end DALC

}//end namespace SAFCore