///////////////////////////////////////////////////////////
//  clsElemento.cs
//  Implementation of the Class clsElemento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore
{
    public class clsElemento
    {

        #region Propiedades
        public Int16? Id;
        public Byte? idGrupoElemento;
        public Byte? idUnidadMedida;
        public String Referencia;
        public String Nombre;
        public Double Mt2;
        public Double Peso;
        public Boolean Rotacion;
        public Boolean Activo;

        #endregion

        #region Construtores
        public clsElemento()
        {

        }

        ~clsElemento()
        {

        }

        public void Dispose(bool disposing)
        {

        }
        #endregion

        #region Metodos


        public enum Campos
        {
            Id, idGrupoElemento, idUnidadMedida, Referencia, Nombre, Mt2, Peso, Rotacion, Activo,
        }
        #endregion

    }//end clsElemento

}//end namespace SAFCore