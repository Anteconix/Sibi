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
        public string nome { get { return this.nome; } }
        public string preco { get { return this.preco; } }

        // método construtor
        public ServicoExtra(string nom, string cid)
        {
            this.nome = nom;
            this.cidade = cid;
        }