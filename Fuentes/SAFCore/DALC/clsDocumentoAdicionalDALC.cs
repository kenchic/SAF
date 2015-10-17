///////////////////////////////////////////////////////////
//  clsDocumentoDALC.cs
//  Implementation of the Class DALC Documento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 12:08:31 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using BaseDatos;

namespace SAFCore
{
    public partial class clsDocumentoAdicionalDALC
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

        public clsDocumentoAdicionalDALC(Comandos ejecutorBaseDatos)
        {
            EjecutorBaseDatos = ejecutorBaseDatos;
        }
        public long consultarSiguienteDocumento(long idTipoDocumento)
        {

            EjecutorBaseDatos.limpiarParametros();
            string sentenciaSQL = " Select Numero From bdDocumento Where Id = @TipoDocumento";
            //EjecutorBaseDatos.agregarParametro(filtro.Campo, filtro.Valor);
            return 0;
        }
    }
}
