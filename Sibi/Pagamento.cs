using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    internal class Pagamento
    {
        // propriedades
        private double valor;
        // private datetime date;
        private string tipo;

        // getters/setters
        public double Valor { get => valor; private set => valor = value; }
        public string Tipo { get => tipo; private set => tipo = value; }

        // método construtor
        public Pagamento(double val, string tip)
        {
            this.valor = val;
            // this.data = dat;
            this.tipo = tip;
        }
    }
}