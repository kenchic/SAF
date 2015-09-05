///////////////////////////////////////////////////////////
//  clsFabricaContrato.cs
//  Implementation of the Class clsContrato
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFCore 
{
    public class  clsFabricaContrato
    {

        public clsFabricaContrato(){

		}

        ~clsFabricaContrato()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsContrato> CrearObjetos(System.Data.DataTable tabla){
		    var lista = new List<clsContrato>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsContrato();
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idAgente = Convert.ToInt16(fila["idAgente"]);
obj.InformacionBD = Convert.ToBoolean(fila["InformacionBD"]);
obj.ContratoAlquiler = Convert.ToBoolean(fila["ContratoAlquiler"]);
obj.CartaPagare = Convert.ToBoolean(fila["CartaPagare"]);
obj.Pagare = Convert.ToBoolean(fila["Pagare"]);
obj.LetraCambio = Convert.ToBoolean(fila["LetraCambio"]);
obj.GarantiasCondiciones = Convert.ToBoolean(fila["GarantiasCondiciones"]);
obj.Deposito = Convert.ToBoolean(fila["Deposito"]);
obj.Anticipo = Convert.ToBoolean(fila["Anticipo"]);
obj.PersonaJuridica = Convert.ToBoolean(fila["PersonaJuridica"]);
obj.PersonaNatural = Convert.ToBoolean(fila["PersonaNatural"]);
obj.FotoCopiaCedula = Convert.ToBoolean(fila["FotoCopiaCedula"]);
obj.FotoCopiaNit = Convert.ToBoolean(fila["FotoCopiaNit"]);
obj.CamaraComercio = Convert.ToBoolean(fila["CamaraComercio"]);

                lista.Add(obj);
            }
            return lista;
		}

public clsContrato CrearObjeto(System.Data.DataTable tabla){
		    clsContrato obj = new clsContrato();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
                obj.Id = Convert.ToInt16(fila["Id"]);
obj.idAgente = Convert.ToInt16(fila["idAgente"]);
obj.InformacionBD = Convert.ToBoolean(fila["InformacionBD"]);
obj.ContratoAlquiler = Convert.ToBoolean(fila["ContratoAlquiler"]);
obj.CartaPagare = Convert.ToBoolean(fila["CartaPagare"]);
obj.Pagare = Convert.ToBoolean(fila["Pagare"]);
obj.LetraCambio = Convert.ToBoolean(fila["LetraCambio"]);
obj.GarantiasCondiciones = Convert.ToBoolean(fila["GarantiasCondiciones"]);
obj.Deposito = Convert.ToBoolean(fila["Deposito"]);
obj.Anticipo = Convert.ToBoolean(fila["Anticipo"]);
obj.PersonaJuridica = Convert.ToBoolean(fila["PersonaJuridica"]);
obj.PersonaNatural = Convert.ToBoolean(fila["PersonaNatural"]);
obj.FotoCopiaCedula = Convert.ToBoolean(fila["FotoCopiaCedula"]);
obj.FotoCopiaNit = Convert.ToBoolean(fila["FotoCopiaNit"]);
obj.CamaraComercio = Convert.ToBoolean(fila["CamaraComercio"]);

            }
            return obj;
		}
    }
}
