///////////////////////////////////////////////////////////
//  clsMovimientoBodegaDALC.cs
//  Implementation of the Class DALC MovimientoBodega
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFcore {

    public partial class clsMovimientoBodegaDALC
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

        public clsMovimientoBodegaDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select id,idelemeto,idbodegaorigen,idbodegadestino,documento,numero,operacion,cantidad From bdMovimientoBodega ";
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

	    private string OrdenSQL(SentenciaSQL sql)
        {
            string ordenar = "";
            if (sql.OrdenBD.Count > 0)
            {
                foreach (var orden in sql.OrdenBD)
                    ordenar += "," + orden;
                ordenar = " Order By " + ordenar.Substring(1);
            }
            return ordenar;
        }

        public clsMovimientoBodega Consultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaMovimientoBodega fab = new clsFabricaMovimientoBodega();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjeto(datos);
        }
        
        public List<clsMovimientoBodega> listConsultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaMovimientoBodega fab = new clsFabricaMovimientoBodega();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjetos(datos);
        }
	    
        public DataTable datatableConsultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);			
            return datos;
        }	
	    
        public int Editar(clsMovimientoBodega obj)
        {
            int resultado=0;
			return resultado;
        }

        public int Eliminar(clsMovimientoBodega obj)
        {
            int resultado=0;
			return resultado;
        }

        public int Insertar(clsMovimientoBodega obj)
        {
            int resultado=0;
			return resultado;  
		}

   }//end DALC

}//end namespace SAFcore