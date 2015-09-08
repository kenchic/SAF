///////////////////////////////////////////////////////////
//  clsAuditoriaDALC.cs
//  Implementation of the Class DALC Auditoria
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

    public partial class clsAuditoriaDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsAuditoria Consultar()
        {
            DataTable datos = new DataTable();
            clsFabricaAuditoria fab = new clsFabricaAuditoria();	
            datos = this.datatableConsultar();
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsAuditoria> listConsultar()
        {
            DataTable datos = new DataTable();
            clsFabricaAuditoria fab = new clsFabricaAuditoria();		
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar()
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerTabla("bdAuditoria");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsAuditoria obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsAuditoria obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsAuditoria obj)
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