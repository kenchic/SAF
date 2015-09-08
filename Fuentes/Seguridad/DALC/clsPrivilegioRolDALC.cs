///////////////////////////////////////////////////////////
//  clsPrivilegioRolDALC.cs
//  Implementation of the Class DALC PrivilegioRol
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

    public partial class clsPrivilegioRolDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsPrivilegioRol Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaPrivilegioRol fab = new clsFabricaPrivilegioRol();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsPrivilegioRol> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaPrivilegioRol fab = new clsFabricaPrivilegioRol();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdPrivilegioRol");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsPrivilegioRol obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsPrivilegioRol obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsPrivilegioRol obj)
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