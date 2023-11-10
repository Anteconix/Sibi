using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    internal class Hospede
    {
        // propriedades
        private string nome;
        private string cpf;
        private string endereco;
        private string telefone;

        // getters/setters
        public string nome { get { return this.nome; } }
        public string cpf { get { return this.cpf; } }
        public string endereco { get { return this.endereco; } }
        public string telefone { get { return this.telefone; } }

        // método construtor
        public Hospede(string nom, string cpf, string end, string tel)
        {
            this.nome = nom;
            this.cpf = cpf;
            this.endereco = end;
            this.telefone = tel;
        }