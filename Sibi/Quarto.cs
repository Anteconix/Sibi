using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    internal class Quarto
    {
        // campos
        private int numero;
        private string tipo;
        private bool disponivel;

        // propriedades
        public int Numero { get => numero; private set => numero = value; }
        public string Tipo { get => tipo; private set => tipo = value; }
        public bool Disponivel { get => disponivel; private set => disponivel = value; }

        // método construtor
        public Quarto(int num, string tip, bool dis)
        {
            this.numero = num;
            this.tipo = tip;
            this.disponivel = dis;
        }
    }
}