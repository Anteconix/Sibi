using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    internal class ServicoExtra
    {
        // propriedades
        private string nome;
        private string preco;

        // getters/setters
        public string Nome { get => nome; private set => nome = value; }
        public string Preco { get => preco; private set => preco = value; }

        // método construtor
        public ServicoExtra(string nom, string pre)
        {
            this.nome = nom;
            this.preco = pre;
        }
    }
}