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
    public partial class clsDocumentoDALC
    {
        

        public long consultarSiguienteDocumento(long idDocumento)
        {
          
            EjecutorBaseDatos.limpiarParametros();
            string sentenciaSQL = " Select Numero From bdDocumento Where Id = @IdDocumento";
            //EjecutorBaseDatos.agregarParametro(filtro.Campo, filtro.Valor);
            return 0;
        }
    }
}
