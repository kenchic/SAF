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

namespace SAFseg {

    public partial class clsParametroSistemaDALC
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

        public clsParametroSistemaDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select * From bdParametroSistema ";
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
        public clsParametroSistema Consultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaParametroSistema fab = new clsFabricaParametroSistema();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(parametros);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsParametroSistema> listConsultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaParametroSistema fab = new clsFabricaParametroSistema();
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

   }//end DALC

}//end namespace SAFseg