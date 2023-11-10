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
        // private datetime data;
        private string tipo;
        s

        // getters/setters
        public string valor { get { return this.valor; } }
        // public string data { get { return this.data; } }
        public string tipo { get { return this.tipo; } }

        // método construtor
        public Pagamento(double val, string tip)
        {
            this.valor = val;
            // this.data = dat;
            this.tipo = tip;
            this.telefone = tel;
        }