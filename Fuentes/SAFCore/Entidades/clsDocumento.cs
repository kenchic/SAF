///////////////////////////////////////////////////////////
//  clsDocumento.cs
//  Implementation of the Class clsDocumento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore
{
    public class clsDocumento
    {

        #region Propiedades
        public Int32? Id;
        public Byte? idTipoDocumento;
        public Int32? Numero;
        public DateTime Fecha;
        public String Descripcion;
        public Boolean Anulado;

        #endregion

        #region Construtores
        public clsDocumento()
        {

        }

        ~clsDocumento()
        {

        }

        public void Dispose(bool disposing)
        {

        }
        #endregion

        #region Metodos


        public enum Campos
        {
            Id, idTipoDocumento, Numero, Fecha, Descripcion, Anulado,
        }
        #endregion

    }//end clsDocumento

}//end namespace SAFCore