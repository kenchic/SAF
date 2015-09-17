///////////////////////////////////////////////////////////
//  clsDetalleRepDevolucionServicioDALC.cs
//  Implementation of the Class DALC DetalleRepDevolucionServicio
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

    public partial class clsDetalleRepDevolucionServicioDALC
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

        public clsDetalleRepDevolucionServicioDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select id,idrepdevolucionservicio,idelemento,cantidad From bdDetalleRepDevolucionServicio ";
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

        public clsDetalleRepDevolucionServicio Consultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleRepDevolucionServicio fab = new clsFabricaDetalleRepDevolucionServicio();

            string SentenciaSQL = "";
            SentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(SentenciaSQL);
            return fab.CrearObjeto(datos);
        }
        
        public List<clsDetalleRepDevolucionServicio> listConsultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaDetalleRepDevolucionServicio fab = new clsFabricaDetalleRepDevolucionServicio();

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
	    
        public int Editar(clsDetalleRepDevolucionServicio obj)
        {
            int resultado=0;
			return resultado;
        }

        public int Eliminar(clsDetalleRepDevolucionServicio obj)
        {
            int resultado=0;
			return resultado;
        }

        public int Insertar(clsDetalleRepDevolucionServicio obj)
        {
            int resultado=0;
			return resultado;  
		}

   }//end DALC

}//end namespace SAFcore