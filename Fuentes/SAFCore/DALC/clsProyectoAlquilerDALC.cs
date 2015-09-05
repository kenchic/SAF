///////////////////////////////////////////////////////////
//  clsProyectoAlquilerDALC.cs
//  Implementation of the Class DALC ProyectoAlquiler
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

    public partial class clsProyectoAlquilerDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsProyectoAlquiler Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaProyectoAlquiler fab = new clsFabricaProyectoAlquiler();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsProyectoAlquiler> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaProyectoAlquiler fab = new clsFabricaProyectoAlquiler();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdProyectoAlquiler");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsProyectoAlquiler obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsProyectoAlquiler obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsProyectoAlquiler obj)
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