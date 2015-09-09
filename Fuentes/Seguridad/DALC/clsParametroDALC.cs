///////////////////////////////////////////////////////////
//  clsParametroDALC.cs
//  Implementation of the Class DALC Parametro
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

    public partial class clsParametroDALC
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

        public clsParametroDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select * From bdParametro ";
            return Select;
        }
        private string CondicionSQL(SentenciaSQL sql)
        {
            string condicion = "";
            if (sql.FiltroBD.Count > 0)
            {
                foreach (var filtro in sql.FiltroBD)
                    condicion += filtro.Filtro;
                condicion = " Where " + condicion.Substring(4);
            }
            return condicion;
        }

	    /// 
        /// 
        public clsParametro Consultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaParametro fab = new clsFabricaParametro();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsParametro> listConsultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaParametro fab = new clsFabricaParametro();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjetos(datos);
        }

	    /// 
        /// 
        public DataTable datatableConsultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);			
            return datos;
        }	

	    /// 
	    /// <param name="obj"></param>
        public int Editar(clsParametro obj)
        {
            int resultado=0;
			return resultado;
        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsParametro obj)
        {
            int resultado=0;
			return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsParametro obj)
        {
            int resultado=0;
			return resultado;  
		}

   }//end DALC

}//end namespace SAFseg