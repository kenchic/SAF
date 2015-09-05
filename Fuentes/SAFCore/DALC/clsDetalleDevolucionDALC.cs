///////////////////////////////////////////////////////////
//  clsDetalleDevolucionDALC.cs
//  Implementation of the Class DALC DetalleDevolucion
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

    public partial class clsDetalleDevolucionDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsDetalleDevolucion Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleDevolucion fab = new clsFabricaDetalleDevolucion();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsDetalleDevolucion> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleDevolucion fab = new clsFabricaDetalleDevolucion();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdDetalleDevolucion");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsDetalleDevolucion obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsDetalleDevolucion obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsDetalleDevolucion obj)
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