///////////////////////////////////////////////////////////
//  clsRemision.cs
//  Implementation of the Class clsRemision
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////

using System;

namespace SAFcore
{
    public class clsRemision
    {

        #region Propiedades
        public Int32? Id;
        public Int16? idProyectoAlquiler;
        public Int16? idProyectoVenta;
        public Int16? idConductor;
        public Int32? Numero;
        public String FechaPedido;
        public String FechaEntrega;
        public DateTime FechaCreacion;
        public String Hora;
        public Boolean Anulado;
        public Boolean Transporte;
        public Decimal ValorTransporte;
        public Boolean Despachado;
        public Boolean EquipoAdecuado;
        public Decimal PesoEquipo;
        public Decimal ValorEquipo;

        #endregion

        #region Construtores
        public clsRemision()
        {

        }

        ~clsRemision()
        {

        }

        public void Dispose(bool disposing)
        {

        }
        #endregion

        #region Metodos


        public enum Campos
        {
            Id, idProyectoAlquiler, idProyectoVenta, idConductor, Numero, FechaPedido, FechaEntrega, FechaCreacion, Hora, Anulado, Transporte, ValorTransporte, Despachado, EquipoAdecuado, PesoEquipo, ValorEquipo,
        }
        #endregion

    }//end clsRemision

}//end namespace SAFCore