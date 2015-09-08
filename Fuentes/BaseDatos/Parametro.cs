using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseDatos
{
    public class ParametroBD
    {
        public enum OperadorLogico
        {
            igual,
            diferente,
            mayor,
            mayorOIgual,
            menor,
            menorOIgual,
            contiene,
            entre
        }

        public string Campo;
        public object Valor;
        public OperadorLogico Operador;
        public string Filtro
        {
            get
            {
                object ValorFiltro = "";
                switch (Valor.GetType().ToString())
                {
                    case "System.Int32":
                        ValorFiltro = Valor;
                        break;
                    default:
                        ValorFiltro = string.Format("'{0}'", Valor);
                        break;
                }

                string par = "";
                switch (Operador)
                {
                    case OperadorLogico.igual:
                        par = string.Format(" AND {0} = {1}", Campo, ValorFiltro);
                        break;
                }
                return par;
            }
        }

        public ParametroBD(string campo, object valor, OperadorLogico operador)
        {
            Campo = campo;
            Valor = valor;
            Operador = operador;
        }
    }
}
