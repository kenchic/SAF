///////////////////////////////////////////////////////////
//  clsRolDALC.cs
//  Implementation of the Class DALC Rol
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

    public partial class clsRolDALC
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

        public clsRolDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select * From bdRol ";
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
        public clsRol Consultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaRol fab = new clsFabricaRol();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(parametros);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsRol> listConsultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaRol fab = new clsFabricaRol();
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
        public int Editar(clsRol obj)
        {
            int resultado=0;
			return resultado;
        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsRol obj)
        {
            int resultado=0;
			return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsRol obj)
        {
            int resultado=0;
			return resultado;  
		}

   }//end DALC

}//end namespace SAFseg