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

namespace SAFseg {

    public partial class clsPrivilegioRolDALC
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

        public clsPrivilegioRolDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select * From bdPrivilegioRol ";
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
        public clsPrivilegioRol Consultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaPrivilegioRol fab = new clsFabricaPrivilegioRol();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(parametros);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsPrivilegioRol> listConsultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaPrivilegioRol fab = new clsFabricaPrivilegioRol();
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

   }//end DALC

}//end namespace SAFseg