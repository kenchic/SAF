///////////////////////////////////////////////////////////
//  clsParametroSistemaDALC.cs
//  Implementation of the Class DALC ParametroSistema
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

    public partial class clsParametroSistemaDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsParametroSistema Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaParametroSistema fab = new clsFabricaParametroSistema();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsParametroSistema> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaParametroSistema fab = new clsFabricaParametroSistema();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdParametroSistema");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsParametroSistema obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsParametroSistema obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsParametroSistema obj)
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