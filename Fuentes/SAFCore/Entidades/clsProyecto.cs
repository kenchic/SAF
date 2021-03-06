///////////////////////////////////////////////////////////
//  clsProyecto.cs
//  Implementation of the Class clsProyecto
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore
{
    public class clsProyecto
    {

        #region Propiedades
        public Int16? Id;
        public Int32? idCliente;
        public Int16? idCiudad;
        public String NombreCliente;
        public String NombreCiudad;
        public String Nombre;
        public String Tipo;
        public String Direccion;
        public String Telefono;
        public String Observacion;
        public String Fecha;
        public String FormaContacto;
        public String SistemaMedida;
        public String IdentificacionResponsable;
        public String NombreResponsable;
        public String TelResponsable;
        public Boolean Activo;
        public Byte? Estado;

        #endregion

        #region Construtores
        public clsProyecto()
        {

        }

        ~clsProyecto()
        {

        }

        public void Dispose(bool disposing)
        {

        }
        #endregion

        #region Metodos


        public enum Campos
        {
            Id, idCliente, idCiudad, NombreCliente, NombreCiudad, Nombre, Tipo, Direccion, Telefono, Observacion, Fecha, FormaContacto, SistemaMedida, IdentificacionResponsable, NombreResponsable, TelResponsable, Activo, Estado,
        }
        #endregion

    }//end clsProyecto

}//end namespace SAFCore