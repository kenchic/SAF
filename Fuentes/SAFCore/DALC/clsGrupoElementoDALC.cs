///////////////////////////////////////////////////////////
//  clsGrupoElementoDALC.cs
//  Implementation of the Class DALC GrupoElemento
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

    public partial class clsGrupoElementoDALC
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

        public clsGrupoElementoDALC(Comandos ejecutorBaseDatos)
        {            
            EjecutorBaseDatos = ejecutorBaseDatos;
        }

        private string construirSelect()
        {
            const string Select = "Select Id,Nombre,Activo From bdGrupoElemento ";
            return Select;
        }

		private string construirInsert(object obj)
        {
            string Insert = "";
            if (obj != null)
            {
                string campos = "";
                string valores = "";
                Type type = obj.GetType();				
                //foreach (PropertyInfo propertyInfo in type.GetProperties())
				foreach (FieldInfo propertyInfo in type.GetFields())
                {
                    //if (propertyInfo.CanRead)
                    {
                        //object valor = propertyInfo.GetValue(obj, null);
						object valor = propertyInfo.GetValue(obj);
                        if (valor != null)
                        {
                            campos += "," + propertyInfo.Name;
                            valores += ",@" + propertyInfo.Name;
                            EjecutorBaseDatos.agregarParametro(propertyInfo.Name, valor);
                        }
                    }
                }

                Insert += string.Format("Insert Into bdGrupoElemento ({0}) Values ({1})", campos.Substring(1), valores.Substring(1));
            }
            return Insert;
        }

        private string construirUpdate(object obj)
        {
            string Update = "";
            if (obj != null)
            {
                string update = "";
                Type type = obj.GetType();
                //foreach (PropertyInfo propertyInfo in type.GetProperties())
				foreach (FieldInfo propertyInfo in type.GetFields())
                {
                    //if (propertyInfo.CanRead)
                    {
                        //object valor = propertyInfo.GetValue(obj, null);
						object valor = propertyInfo.GetValue(obj);
                        if (valor != null)
                        {
                            update += ", " + propertyInfo.Name + " = @" + propertyInfo.Name;
                            EjecutorBaseDatos.agregarParametro(propertyInfo.Name, valor);
                        }
                    }
                }

                Update = string.Format("Update bdGrupoElemento SET {0}", update.Substring(1));
            }
            return Update;
        }

		private string construirDelete()
        {
            const string Delete = "Delete bdGrupoElemento ";
            return Delete;
        }

        private string CondicionSQL(SentenciaSQL sql)
        {
            string condicion = "";
            if (sql.FiltroBD.Count > 0)
            {                
                foreach (var filtro in sql.FiltroBD)
                {
                    EjecutorBaseDatos.agregarParametro(filtro.Campo,filtro.Valor);
                    condicion += filtro.Filtro;
                }
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

        public clsGrupoElemento Consultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaGrupoElemento fab = new clsFabricaGrupoElemento();

            string sentenciaSQL = "";
			EjecutorBaseDatos.limpiarParametros();
            sentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(sentenciaSQL);
            return fab.CrearObjeto(datos);
        }
        
        public List<clsGrupoElemento> listConsultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            clsFabricaGrupoElemento fab = new clsFabricaGrupoElemento();

            string sentenciaSQL = "";
			EjecutorBaseDatos.limpiarParametros();
            sentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(sentenciaSQL);
            return fab.CrearObjetos(datos);
        }
	    
        public DataTable datatableConsultar(SentenciaSQL sql)
        {
            DataTable datos = new DataTable();
            string sentenciaSQL = "";
			EjecutorBaseDatos.limpiarParametros();
            sentenciaSQL = construirSelect() + CondicionSQL(sql);
            datos = EjecutorBaseDatos.obtenerConsulta(sentenciaSQL);			
            return datos;
        }	
	    
        public int Editar(clsGrupoElemento obj, SentenciaSQL sql)
        {
            int resultado = 0;
            EjecutorBaseDatos.limpiarParametros();
            string sentenciaSQL = construirUpdate(obj) + CondicionSQL(sql);
            resultado = EjecutorBaseDatos.ejecutarSentencia(sentenciaSQL);
            return resultado;
        }

        public int Eliminar(clsGrupoElemento obj, SentenciaSQL sql)
        {
            int resultado=0;
			EjecutorBaseDatos.limpiarParametros();
            string sentenciaSQL = construirDelete() + CondicionSQL(sql);
            resultado = EjecutorBaseDatos.ejecutarSentencia(sentenciaSQL);
			return resultado;
        }

        public int Insertar(clsGrupoElemento obj)
        {
            int resultado = 0;
			EjecutorBaseDatos.limpiarParametros();
            string sentenciaSQL = construirInsert(obj);
            resultado = EjecutorBaseDatos.ejecutarSentenciaInsert(sentenciaSQL);
            return resultado;  
		}

   }//end DALC

}//end namespace SAFcore