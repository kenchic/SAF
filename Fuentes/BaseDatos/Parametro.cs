using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ParametroBD(string campo, object valor, OperadorLogico operador)
        {
            Campo = campo;
            Valor = valor;
            Operador = operador;
        }
    }
}
