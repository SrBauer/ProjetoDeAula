using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvAssociacao
{
    public class Receita
    {
        public String tipo { get; private set; }
        public float valor { get; private set; }

        public Receita(string tipo, float valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }
    }
}
