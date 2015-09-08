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

namespace SAFseg {

    public partial class clsAuditoriaDALC
    {
        private Comandos m_ejecutorBaseDatos;
        public Comandos EjecutorBaseDatos
        {
            get { return m_ejecutorBaseDatos; }
            set { m_ejecutorBaseDatos = value; }
        }        

        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }

        public clsAuditoriaDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select * From bdAuditoria ";
            return Select;
        }
        private string CondicionSQL(List<ParametroBD> parametros)
        {
            string condicion = "";
            if (parametros.Count > 0)
            {
                foreach (var parametro in parametros)
                    condicion += parametro.Filtro;
                condicion = " Where " + condicion.Substring(4);
            }
            return condicion;
        }

	    /// 
        /// 
        public clsAuditoria Consultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaAuditoria fab = new clsFabricaAuditoria();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(parametros);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsAuditoria> listConsultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaAuditoria fab = new clsFabricaAuditoria();
            datos = EjecutorBaseDatos.obtenerConsulta("");
            return fab.CrearObjetos(datos);
        }

	    /// 
        /// 
        public DataTable datatableConsultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerConsulta("");			
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

   }//end DALC

}//end namespace SAFseg