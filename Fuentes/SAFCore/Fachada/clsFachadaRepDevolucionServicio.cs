///////////////////////////////////////////////////////////
//  clsFachada.cs
//  Implementation of the Class Fachada SAFcore
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

    public partial class clsFachadaSAFcore
    {
        #region Metodos
        public clsRepDevolucionServicio consultarEntidadRepDevolucionServicio(SentenciaSQL sql)
        {
            m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsRepDevolucionServicioDALC.Consultar(sql);
        }

        public DataTable consultarDatosRepDevolucionServicio(SentenciaSQL sql)
        {
            m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsRepDevolucionServicioDALC.datatableConsultar(sql);
        }

        public List<clsRepDevolucionServicio> consultarListaRepDevolucionServicio(SentenciaSQL sql)
        {
            m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsRepDevolucionServicioDALC.listConsultar(sql);
        }

        public int insertarRepDevolucionServicio(clsRepDevolucionServicio obj)
        {
            m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsRepDevolucionServicioDALC.Insertar(obj);
        }

        public int editarRepDevolucionServicio(clsRepDevolucionServicio obj, SentenciaSQL sql)
        {
            m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsRepDevolucionServicioDALC.Editar(obj, sql);
        }

        public int eliminarRepDevolucionServicio(clsRepDevolucionServicio obj, SentenciaSQL sql)
        {
            m_clsRepDevolucionServicioDALC = new clsRepDevolucionServicioDALC(m_EjecutorBaseDatos);
            return m_clsRepDevolucionServicioDALC.Eliminar(obj, sql);
        }
        #endregion

   }//end Fachada

}//end namespace SAFCore