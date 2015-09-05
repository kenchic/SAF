///////////////////////////////////////////////////////////
//  clsFachadaSAF.cs
//  Implementation of the Class Fachada SAF
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

    public partial class clsFachadaSAF
    {
        private Comandos m_EjecutorBaseDatos;
        #region Miembros
        private clsAgenteDALC m_clsAgenteDALC;
private clsAuditoriaDALC m_clsAuditoriaDALC;
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
private clsEventoAuditoriaDALC m_clsEventoAuditoriaDALC;
private clsFacturaDALC m_clsFacturaDALC;
private clsGrupoElementoDALC m_clsGrupoElementoDALC;
private clsListaPrecioDALC m_clsListaPrecioDALC;
private clsMantenimientoDALC m_clsMantenimientoDALC;
private clsMovimientoBodegaDALC m_clsMovimientoBodegaDALC;
private clsOrdenServicioDALC m_clsOrdenServicioDALC;
private clsParametroDALC m_clsParametroDALC;
private clsParametroSistemaDALC m_clsParametroSistemaDALC;
private clsPrivilegioDALC m_clsPrivilegioDALC;
private clsPrivilegioRolDALC m_clsPrivilegioRolDALC;
private clsProveedorDALC m_clsProveedorDALC;
private clsProyectoDALC m_clsProyectoDALC;
private clsProyectoAlquilerDALC m_clsProyectoAlquilerDALC;
private clsProyectoVentaDALC m_clsProyectoVentaDALC;
private clsRemisionDALC m_clsRemisionDALC;
private clsRepDevolucionServicioDALC m_clsRepDevolucionServicioDALC;
private clsReposicionDALC m_clsReposicionDALC;
private clsRolDALC m_clsRolDALC;
private clsTipoDocumentoDALC m_clsTipoDocumentoDALC;
private clsUnidadMedidaDALC m_clsUnidadMedidaDALC;
private clsUsuarioDALC m_clsUsuarioDALC;
private clsVentaDALC m_clsVentaDALC;

        #endregion

        public void Dispose()
        {            
            GC.SuppressFinalize(this);
        }
	
        #region Metodos

	#region Agente
public clsAgente consultarEntidadAgente(Dictionary<string, string> parametro){
return null;
} 

public clsAgente consultarDatosAgente(Dictionary<string, string> parametro){
return null;
} 

public clsAgente consultarListaAgente(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Auditoria
public clsAuditoria consultarEntidadAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsAuditoria consultarDatosAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsAuditoria consultarListaAuditoria(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Bodega
public clsBodega consultarEntidadBodega(Dictionary<string, string> parametro){
return null;
} 

public clsBodega consultarDatosBodega(Dictionary<string, string> parametro){
return null;
} 

public clsBodega consultarListaBodega(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Ciudad
public clsCiudad consultarEntidadCiudad(Dictionary<string, string> parametro){
return null;
} 

public clsCiudad consultarDatosCiudad(Dictionary<string, string> parametro){
return null;
} 

public clsCiudad consultarListaCiudad(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Cliente
public clsCliente consultarEntidadCliente(Dictionary<string, string> parametro){
return null;
} 

public clsCliente consultarDatosCliente(Dictionary<string, string> parametro){
return null;
} 

public clsCliente consultarListaCliente(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Conductor
public clsConductor consultarEntidadConductor(Dictionary<string, string> parametro){
return null;
} 

public clsConductor consultarDatosConductor(Dictionary<string, string> parametro){
return null;
} 

public clsConductor consultarListaConductor(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Contrato
public clsContrato consultarEntidadContrato(Dictionary<string, string> parametro){
return null;
} 

public clsContrato consultarDatosContrato(Dictionary<string, string> parametro){
return null;
} 

public clsContrato consultarListaContrato(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Corte
public clsCorte consultarEntidadCorte(Dictionary<string, string> parametro){
return null;
} 

public clsCorte consultarDatosCorte(Dictionary<string, string> parametro){
return null;
} 

public clsCorte consultarListaCorte(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleCorte
public clsDetalleCorte consultarEntidadDetalleCorte(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleCorte consultarDatosDetalleCorte(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleCorte consultarListaDetalleCorte(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleDevolucion
public clsDetalleDevolucion consultarEntidadDetalleDevolucion(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleDevolucion consultarDatosDetalleDevolucion(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleDevolucion consultarListaDetalleDevolucion(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleDevolucionServicio
public clsDetalleDevolucionServicio consultarEntidadDetalleDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleDevolucionServicio consultarDatosDetalleDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleDevolucionServicio consultarListaDetalleDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleDocumento
public clsDetalleDocumento consultarEntidadDetalleDocumento(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleDocumento consultarDatosDetalleDocumento(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleDocumento consultarListaDetalleDocumento(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleFactura
public clsDetalleFactura consultarEntidadDetalleFactura(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleFactura consultarDatosDetalleFactura(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleFactura consultarListaDetalleFactura(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleListaPrecio
public clsDetalleListaPrecio consultarEntidadDetalleListaPrecio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleListaPrecio consultarDatosDetalleListaPrecio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleListaPrecio consultarListaDetalleListaPrecio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleMantenimiento
public clsDetalleMantenimiento consultarEntidadDetalleMantenimiento(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleMantenimiento consultarDatosDetalleMantenimiento(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleMantenimiento consultarListaDetalleMantenimiento(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleOrdenServicio
public clsDetalleOrdenServicio consultarEntidadDetalleOrdenServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleOrdenServicio consultarDatosDetalleOrdenServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleOrdenServicio consultarListaDetalleOrdenServicio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleRemision
public clsDetalleRemision consultarEntidadDetalleRemision(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleRemision consultarDatosDetalleRemision(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleRemision consultarListaDetalleRemision(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleRepDevolucionServicio
public clsDetalleRepDevolucionServicio consultarEntidadDetalleRepDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleRepDevolucionServicio consultarDatosDetalleRepDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleRepDevolucionServicio consultarListaDetalleRepDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleReposicion
public clsDetalleReposicion consultarEntidadDetalleReposicion(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleReposicion consultarDatosDetalleReposicion(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleReposicion consultarListaDetalleReposicion(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DetalleVenta
public clsDetalleVenta consultarEntidadDetalleVenta(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleVenta consultarDatosDetalleVenta(Dictionary<string, string> parametro){
return null;
} 

public clsDetalleVenta consultarListaDetalleVenta(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Devolucion
public clsDevolucion consultarEntidadDevolucion(Dictionary<string, string> parametro){
return null;
} 

public clsDevolucion consultarDatosDevolucion(Dictionary<string, string> parametro){
return null;
} 

public clsDevolucion consultarListaDevolucion(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region DevolucionServicio
public clsDevolucionServicio consultarEntidadDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDevolucionServicio consultarDatosDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsDevolucionServicio consultarListaDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Documento
public clsDocumento consultarEntidadDocumento(Dictionary<string, string> parametro){
return null;
} 

public clsDocumento consultarDatosDocumento(Dictionary<string, string> parametro){
return null;
} 

public clsDocumento consultarListaDocumento(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Elemento
public clsElemento consultarEntidadElemento(Dictionary<string, string> parametro){
return null;
} 

public clsElemento consultarDatosElemento(Dictionary<string, string> parametro){
return null;
} 

public clsElemento consultarListaElemento(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region EventoAuditoria
public clsEventoAuditoria consultarEntidadEventoAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsEventoAuditoria consultarDatosEventoAuditoria(Dictionary<string, string> parametro){
return null;
} 

public clsEventoAuditoria consultarListaEventoAuditoria(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Factura
public clsFactura consultarEntidadFactura(Dictionary<string, string> parametro){
return null;
} 

public clsFactura consultarDatosFactura(Dictionary<string, string> parametro){
return null;
} 

public clsFactura consultarListaFactura(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region GrupoElemento
public clsGrupoElemento consultarEntidadGrupoElemento(Dictionary<string, string> parametro){
return null;
} 

public clsGrupoElemento consultarDatosGrupoElemento(Dictionary<string, string> parametro){
return null;
} 

public clsGrupoElemento consultarListaGrupoElemento(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region ListaPrecio
public clsListaPrecio consultarEntidadListaPrecio(Dictionary<string, string> parametro){
return null;
} 

public clsListaPrecio consultarDatosListaPrecio(Dictionary<string, string> parametro){
return null;
} 

public clsListaPrecio consultarListaListaPrecio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Mantenimiento
public clsMantenimiento consultarEntidadMantenimiento(Dictionary<string, string> parametro){
return null;
} 

public clsMantenimiento consultarDatosMantenimiento(Dictionary<string, string> parametro){
return null;
} 

public clsMantenimiento consultarListaMantenimiento(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region MovimientoBodega
public clsMovimientoBodega consultarEntidadMovimientoBodega(Dictionary<string, string> parametro){
return null;
} 

public clsMovimientoBodega consultarDatosMovimientoBodega(Dictionary<string, string> parametro){
return null;
} 

public clsMovimientoBodega consultarListaMovimientoBodega(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region OrdenServicio
public clsOrdenServicio consultarEntidadOrdenServicio(Dictionary<string, string> parametro){
return null;
} 

public clsOrdenServicio consultarDatosOrdenServicio(Dictionary<string, string> parametro){
return null;
} 

public clsOrdenServicio consultarListaOrdenServicio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Parametro
public clsParametro consultarEntidadParametro(Dictionary<string, string> parametro){
return null;
} 

public clsParametro consultarDatosParametro(Dictionary<string, string> parametro){
return null;
} 

public clsParametro consultarListaParametro(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region ParametroSistema
public clsParametroSistema consultarEntidadParametroSistema(Dictionary<string, string> parametro){
return null;
} 

public clsParametroSistema consultarDatosParametroSistema(Dictionary<string, string> parametro){
return null;
} 

public clsParametroSistema consultarListaParametroSistema(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Privilegio
public clsPrivilegio consultarEntidadPrivilegio(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegio consultarDatosPrivilegio(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegio consultarListaPrivilegio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region PrivilegioRol
public clsPrivilegioRol consultarEntidadPrivilegioRol(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegioRol consultarDatosPrivilegioRol(Dictionary<string, string> parametro){
return null;
} 

public clsPrivilegioRol consultarListaPrivilegioRol(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Proveedor
public clsProveedor consultarEntidadProveedor(Dictionary<string, string> parametro){
return null;
} 

public clsProveedor consultarDatosProveedor(Dictionary<string, string> parametro){
return null;
} 

public clsProveedor consultarListaProveedor(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Proyecto
public clsProyecto consultarEntidadProyecto(Dictionary<string, string> parametro){
return null;
} 

public clsProyecto consultarDatosProyecto(Dictionary<string, string> parametro){
return null;
} 

public clsProyecto consultarListaProyecto(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region ProyectoAlquiler
public clsProyectoAlquiler consultarEntidadProyectoAlquiler(Dictionary<string, string> parametro){
return null;
} 

public clsProyectoAlquiler consultarDatosProyectoAlquiler(Dictionary<string, string> parametro){
return null;
} 

public clsProyectoAlquiler consultarListaProyectoAlquiler(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region ProyectoVenta
public clsProyectoVenta consultarEntidadProyectoVenta(Dictionary<string, string> parametro){
return null;
} 

public clsProyectoVenta consultarDatosProyectoVenta(Dictionary<string, string> parametro){
return null;
} 

public clsProyectoVenta consultarListaProyectoVenta(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Remision
public clsRemision consultarEntidadRemision(Dictionary<string, string> parametro){
return null;
} 

public clsRemision consultarDatosRemision(Dictionary<string, string> parametro){
return null;
} 

public clsRemision consultarListaRemision(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region RepDevolucionServicio
public clsRepDevolucionServicio consultarEntidadRepDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsRepDevolucionServicio consultarDatosRepDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

public clsRepDevolucionServicio consultarListaRepDevolucionServicio(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Reposicion
public clsReposicion consultarEntidadReposicion(Dictionary<string, string> parametro){
return null;
} 

public clsReposicion consultarDatosReposicion(Dictionary<string, string> parametro){
return null;
} 

public clsReposicion consultarListaReposicion(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Rol
public clsRol consultarEntidadRol(Dictionary<string, string> parametro){
return null;
} 

public clsRol consultarDatosRol(Dictionary<string, string> parametro){
return null;
} 

public clsRol consultarListaRol(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region TipoDocumento
public clsTipoDocumento consultarEntidadTipoDocumento(Dictionary<string, string> parametro){
return null;
} 

public clsTipoDocumento consultarDatosTipoDocumento(Dictionary<string, string> parametro){
return null;
} 

public clsTipoDocumento consultarListaTipoDocumento(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region UnidadMedida
public clsUnidadMedida consultarEntidadUnidadMedida(Dictionary<string, string> parametro){
return null;
} 

public clsUnidadMedida consultarDatosUnidadMedida(Dictionary<string, string> parametro){
return null;
} 

public clsUnidadMedida consultarListaUnidadMedida(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Usuario
public clsUsuario consultarEntidadUsuario(Dictionary<string, string> parametro){
return null;
} 

public clsUsuario consultarDatosUsuario(Dictionary<string, string> parametro){
return null;
} 

public clsUsuario consultarListaUsuario(Dictionary<string, string> parametro){
return null;
} 

#endregion
#region Venta
public clsVenta consultarEntidadVenta(Dictionary<string, string> parametro){
return null;
} 

public clsVenta consultarDatosVenta(Dictionary<string, string> parametro){
return null;
} 

public clsVenta consultarListaVenta(Dictionary<string, string> parametro){
return null;
} 

#endregion


        #endregion

   }//end DALC

}//end namespace SAFCore