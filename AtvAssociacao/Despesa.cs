using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace AtvAssociacao
{
    public class Despesa
    {

        public float valor { get; set; }
        public String tipo { get; set; }


        public Despesa(float valor, string tipo)
        {
            this.valor = valor;
            this.tipo = tipo;
        }

        public Despesa(string v1, float v2)
        {
        }
    }
}
