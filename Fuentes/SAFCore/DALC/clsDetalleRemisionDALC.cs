///////////////////////////////////////////////////////////
//  clsDetalleRemisionDALC.cs
//  Implementation of the Class DALC DetalleRemision
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

    public partial class clsDetalleRemisionDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsDetalleRemision Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleRemision fab = new clsFabricaDetalleRemision();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsDetalleRemision> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleRemision fab = new clsFabricaDetalleRemision();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdDetalleRemision");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsDetalleRemision obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsDetalleRemision obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsDetalleRemision obj)
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