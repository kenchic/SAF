///////////////////////////////////////////////////////////
//  clsDevolucionServicioDALC.cs
//  Implementation of the Class DALC DevolucionServicio
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

    public partial class clsDevolucionServicioDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsDevolucionServicio Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDevolucionServicio fab = new clsFabricaDevolucionServicio();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsDevolucionServicio> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaDevolucionServicio fab = new clsFabricaDevolucionServicio();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdDevolucionServicio");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsDevolucionServicio obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsDevolucionServicio obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsDevolucionServicio obj)
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