///////////////////////////////////////////////////////////
//  clsUsuarioDALC.cs
//  Implementation of the Class DALC Usuario
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

    public partial class clsUsuarioDALC
    {
        private Comandos m_ejecutor_base_datos;
        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	/// 
        /// 
        public clsUsuario Consultar(List<ParametroBD> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaUsuario fab = new clsFabricaUsuario();

            //Parametros
            string condicion = "";
            EjecutorBaseDatos.limpiarParametros();
            foreach (var parametro in parametros)
            {
                EjecutorBaseDatos.agregarParametro(parametro.Campo, parametro.Valor);
                condicion += con
            }
            EjecutorBaseDatos.agregarParametroCursor();

            datos = EjecutorBaseDatos.obtenerConsulta("Select * From bdUsuarios");
            return fab.CrearObjeto(datos);
        }

        /// 
        /// 
        public List<clsUsuario> listConsultar(Dictionary<string, string> parametros)
        {
            DataTable datos = new DataTable();
            clsFabricaUsuario fab = new clsFabricaUsuario();
            datos = EjecutorBaseDatos.obtenerConsulta("");
            return fab.CrearObjetos(datos);
        }

	/// 
        /// 
        public DataTable datatableConsultar(Dictionary<string, string> parametros)
        {
            DataTable datos = new DataTable();
            datos = EjecutorBaseDatos.obtenerConsulta("");			
            return datos;
        }	

	/// 
	/// <param name="obj"></param>
        public int Editar(clsUsuario obj)
        {
            int resultado=0;
	    return resultado;

        }
		/// 
		/// <param name="obj"></param>
        public int Eliminar(clsUsuario obj)
        {
            int resultado=0;
	    return resultado;
        }

		/// 
		/// <param name="obj"></param>
        public int Insertar(clsUsuario obj)
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