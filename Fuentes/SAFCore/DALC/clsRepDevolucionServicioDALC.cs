///////////////////////////////////////////////////////////
//  clsRepDevolucionServicioDALC.cs
//  Implementation of the Class DALC RepDevolucionServicio
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

    public partial class clsRepDevolucionServicioDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsRepDevolucionServicio Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaRepDevolucionServicio fab = new clsFabricaRepDevolucionServicio();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsRepDevolucionServicio> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaRepDevolucionServicio fab = new clsFabricaRepDevolucionServicio();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdRepDevolucionServicio");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsRepDevolucionServicio obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsRepDevolucionServicio obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsRepDevolucionServicio obj)
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