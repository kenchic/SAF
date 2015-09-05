///////////////////////////////////////////////////////////
//  clsDetalleReposicionDALC.cs
//  Implementation of the Class DALC DetalleReposicion
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

    public partial class clsDetalleReposicionDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsDetalleReposicion Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleReposicion fab = new clsFabricaDetalleReposicion();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsDetalleReposicion> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleReposicion fab = new clsFabricaDetalleReposicion();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdDetalleReposicion");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsDetalleReposicion obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsDetalleReposicion obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsDetalleReposicion obj)
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