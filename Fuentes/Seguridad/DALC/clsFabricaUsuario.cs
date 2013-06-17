
using System;
using System.Collections.Generic;

namespace Seguridad.DALC
{
    public class  clsFabricaUsuario : IFabricaEntidad<clsUsuario>
    {

        public clsFabricaUsuario(){

		}

        ~clsFabricaUsuario()
        {

		}

		public virtual void Dispose(){

		}

		/// 
		/// <param name="tabla">Fila de la tabla para hacer el Binding de los datos.</param>
		public List<clsUsuario> CrearObjetos(ref System.Data.DataTable tabla){
		    var lista = new List<clsUsuario>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new clsUsuario();
                obj.Id = Convert.ToInt64(fila["Id"]);
                obj.Clave = fila["Clave"].ToString();
                obj.Activo = Convert.ToBoolean(fila["Activo"]);
                obj.Nombre = fila["Nombre"].ToString();
                obj.Apellido = fila["Apellido"].ToString();
                obj.Identificacion = fila["Identificacion"].ToString();
                obj.Correo = fila["Correo"].ToString();
                lista.Add(obj);
            }
            return lista;
		}
    }
}
