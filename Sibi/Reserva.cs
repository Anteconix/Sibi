using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    internal class Reserva
    {
        // campos
        private string nome;
        private string cpf;
        private string endereco;
        private string telefone;
        private List<Tela> telas = new List<Tela>();


        // propriedades
        public string Nome { get => nome; private set => nome = value; }
        public string Cpf { get => cpf; private set => cpf = value; }
        public string Endereco { get => endereco; private set => endereco = value; }
        public string Telefone { get => telefone; private set => telefone = value; }


        // método construtor
        public Reserva(string nom, string cpf, string end, string tel)
        {
            this.nome = nom;
            this.cpf = cpf;
            this.endereco = end;
            this.telefone = tel;
        }
    }
}