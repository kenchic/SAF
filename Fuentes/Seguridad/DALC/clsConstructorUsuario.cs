
using System;
using System.Collections.Generic;

namespace Seguridad.DALC
{
    public class  ClsConstructorUsuario : IConstructorEntidad<ClsUsuario>
    {

        public ClsConstructorUsuario(){

		}

        ~ClsConstructorUsuario()
        {

		}

		public virtual void Dispose(){

		}

		/// 
		/// <param name="tabla">Fila de la tabla para hacer el Binding de los datos.</param>
		public List<ClsUsuario> CrearObjetos(ref System.Data.DataTable tabla){
		    var lista = new List<ClsUsuario>();
            foreach (System.Data.DataRow fila in tabla.Rows)
            {
                var obj = new ClsUsuario();
                obj.Activo = Convert.ToBoolean(fila["Activo"]);
                obj.Nombre = fila["Nombre"].ToString();
                obj.Id = Convert.ToInt64(fila["Id"]);
                obj.Apellido = fila["Apellido"].ToString();
                obj.Identificacion = fila["Identificacion"].ToString();
                obj.Correo = fila["Correo"].ToString();
                lista.Add(obj);
            }
            return lista;
		}
    }
}
