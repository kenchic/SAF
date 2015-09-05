///////////////////////////////////////////////////////////
//  clsOrdenServicioDALC.cs
//  Implementation of the Class DALC OrdenServicio
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

    public partial class clsOrdenServicioDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsOrdenServicio Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaOrdenServicio fab = new clsFabricaOrdenServicio();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsOrdenServicio> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaOrdenServicio fab = new clsFabricaOrdenServicio();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdOrdenServicio");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsOrdenServicio obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsOrdenServicio obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsOrdenServicio obj)
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