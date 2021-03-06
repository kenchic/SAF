///////////////////////////////////////////////////////////
//  clsFabricaElemento.cs
//  Implementation of the Class clsElemento
//  SAF - Integral Solutions SAS
//  Created on:      05-abr-2013 04:12:44 p.m.
//  Original author: German Alvarez
///////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace SAFcore 
{
    public class  clsFabricaElemento
    {

        public clsFabricaElemento(){

		}

        ~clsFabricaElemento()
        {

		}

		public virtual void Dispose(){

		}

		
		public List<clsElemento> CrearObjetos(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
		    var lista = new List<clsElemento>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
				var obj = new clsElemento();
				obj.Id = Convert.ToInt16(fila["Id"]);
obj.idGrupoElemento = Convert.ToByte(fila["idGrupoElemento"]);
obj.idUnidadMedida = Convert.ToByte(fila["idUnidadMedida"]);
obj.Referencia = fila["Referencia"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Mt2 = Convert.ToDouble(fila["Mt2"]);
obj.Peso = Convert.ToDouble(fila["Peso"]);
obj.Rotacion = Convert.ToBoolean(fila["Rotacion"]);
obj.Activo = Convert.ToBoolean(fila["Activo"]);

				lista.Add(obj);
            }
            return lista;
		}

        public clsElemento CrearObjeto(System.Data.DataTable tabla){
			if (tabla.Rows.Count == 0) return null;
            clsElemento obj = new clsElemento();
            System.Data.DataRow fila =  tabla.Rows[0];
            {                
			    obj.Id = Convert.ToInt16(fila["Id"]);
obj.idGrupoElemento = Convert.ToByte(fila["idGrupoElemento"]);
obj.idUnidadMedida = Convert.ToByte(fila["idUnidadMedida"]);
obj.Referencia = fila["Referencia"].ToString();
obj.Nombre = fila["Nombre"].ToString();
obj.Mt2 = Convert.ToDouble(fila["Mt2"]);
obj.Peso = Convert.ToDouble(fila["Peso"]);
obj.Rotacion = Convert.ToBoolean(fila["Rotacion"]);
obj.Activo = Convert.ToBoolean(fila["Activo"]);

            }
            return obj;
		}
    }
}
