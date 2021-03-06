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
        private Comandos m_EjecutorBaseDatos;
        #region Miembros
        private clsAgenteDALC m_clsAgenteDALC;
private clsBodegaDALC m_clsBodegaDALC;
private clsCiudadDALC m_clsCiudadDALC;
private clsClienteDALC m_clsClienteDALC;
private clsConductorDALC m_clsConductorDALC;
private clsContratoDALC m_clsContratoDALC;
private clsCorteDALC m_clsCorteDALC;
private clsDetalleCorteDALC m_clsDetalleCorteDALC;
private clsDetalleDevolucionDALC m_clsDetalleDevolucionDALC;
private clsDetalleDevolucionServicioDALC m_clsDetalleDevolucionServicioDALC;
private clsDetalleDocumentoDALC m_clsDetalleDocumentoDALC;
private clsDetalleFacturaDALC m_clsDetalleFacturaDALC;
private clsDetalleListaPrecioDALC m_clsDetalleListaPrecioDALC;
private clsDetalleMantenimientoDALC m_clsDetalleMantenimientoDALC;
private clsDetalleOrdenServicioDALC m_clsDetalleOrdenServicioDALC;
private clsDetalleRemisionDALC m_clsDetalleRemisionDALC;
private clsDetalleRepDevolucionServicioDALC m_clsDetalleRepDevolucionServicioDALC;
private clsDetalleReposicionDALC m_clsDetalleReposicionDALC;
private clsDetalleVentaDALC m_clsDetalleVentaDALC;
private clsDevolucionDALC m_clsDevolucionDALC;
private clsDevolucionServicioDALC m_clsDevolucionServicioDALC;
private clsDocumentoDALC m_clsDocumentoDALC;
private clsElementoDALC m_clsElementoDALC;
private clsFacturaDALC m_clsFacturaDALC;
private clsGrupoElementoDALC m_clsGrupoElementoDALC;
private clsListaPrecioDALC m_clsListaPrecioDALC;
private clsMantenimientoDALC m_clsMantenimientoDALC;
private clsMovimientoBodegaDALC m_clsMovimientoBodegaDALC;
private clsOrdenServicioDALC m_clsOrdenServicioDALC;
private clsParametroDALC m_clsParametroDALC;
private clsParametroSistemaDALC m_clsParametroSistemaDALC;
private clsProveedorDALC m_clsProveedorDALC;
private clsProyectoDALC m_clsProyectoDALC;
private clsProyectoAlquilerDALC m_clsProyectoAlquilerDALC;
private clsProyectoVentaDALC m_clsProyectoVentaDALC;
private clsRemisionDALC m_clsRemisionDALC;
private clsRepDevolucionServicioDALC m_clsRepDevolucionServicioDALC;
private clsReposicionDALC m_clsReposicionDALC;
private clsTipoDocumentoDALC m_clsTipoDocumentoDALC;
private clsUnidadMedidaDALC m_clsUnidadMedidaDALC;
private clsVentaDALC m_clsVentaDALC;

        #endregion

		public clsFachadaSAFcore(ref Comandos ejecutor)
        {
            this.m_EjecutorBaseDatos = ejecutor;
        }

        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }

   }//end Fachada

}//end namespace SAFcore