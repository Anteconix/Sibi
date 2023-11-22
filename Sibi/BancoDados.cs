using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    // esta classe fornece serviço de guarda dos dados
    public class BancoDados
    {
        List<Hospede> hospedes = new List<Hospede>();
        List<Hotel> hoteis = new List<Hotel>();
        List<Pagamento> pagamentos = new List<Pagamento>();
        List<Quarto> quartos = new List<Quarto>();
        List<RedeHoteis> redeshoteis = new List<RedeHoteis>();
        List<Reserva> reservas = new List<Reserva>();
        List<ServicoExtra> servicosextras = new List<ServicoExtra>();


        public BancoDados()
        {
            // cria alguns registros para realizar permitir o uso rápido do sistema


            // adiciona alguns hoteis
            this.hoteis.Add(new Hotel("Mont'Rei", "Joinville"));
            this.hoteis.Add(new Hotel("Glorian Real", "Barra Velha"));

            // adiciona alguns Quartos
            this.quartos.Add(new Quarto(1001, "Suíte Premium", "1"));
            this.quartos.Add(new Quarto(101, "Suíte Báscia", "0"));

            // adicona alguns hospedes
            this.hospedes.Add(new Hospede("Carlos Magno", "00000000000", "Rua Fulano de Tal, 101", "4799999-9999"));
            this.hospedes.Add(new Hospede("Bryann Lucas", "10000000000", "Rua Fulano de Tal, 102", "4799999-9991"));
            this.hospedes.Add(new Hospede("Rafael Pavesi", "20000000000", "Rua Fulano de Tal, 103", "4799999-9992"));


        }


        public int buscar(string onde, string oque)
        {
            int posicao = -1;

            if (onde == "autor") posicao = this.autores.FindIndex(o => o.Codigo == oque);
            if (onde == "autor") posicao = this.autores.FindIndex(o => o.Codigo == oque);
            if (onde == "autor") posicao = this.autores.FindIndex(o => o.Codigo == oque);
            if (onde == "autor") posicao = this.autores.FindIndex(o => o.Codigo == oque);


            return posicao;
        }


        public object recuperar(string onde, int qual)
        {
            Object obj = null;
            if (onde == "editora") obj = this.editoras[qual];
            if (onde == "autor") obj = this.autores[qual];
            if (onde == "livro") obj = this.livros[qual];
            if (onde == "anotacao") obj = this.anotacoes[qual];
            return obj;
        }


        public void gravar(string onde, Object oque)
        {
            if (onde == "editora") this.editoras.Add((Editora)oque);
            if (onde == "autor") this.autores.Add((Autor)oque);
            if (onde == "livro") this.livros.Add((Livro)oque);
        }


        public void alterar(string onde, Object oque, Object novo)
        {
            if (onde == "editora")
            {
                int x = this.buscar("editora", ((Editora)oque).Codigo);
                this.editoras[x] = (Editora)novo;
            }

            if (onde == "autor")
            {
                int x = this.buscar("autor", ((Autor)oque).Codigo);
                this.autores[x] = (Autor)novo;
            }

            if (onde == "livro")
            {
                int x = this.buscar("livro", ((Livro)oque).Codigo);
                this.livros[x] = (Livro)novo;
            }
        }


        public void excluir(string onde, Object oque)
        {
            if (onde == "editora") this.editoras.Remove((Editora)oque);
            if (onde == "autor") this.autores.Remove((Autor)oque);
            if (onde == "livro") this.livros.Remove((Livro)oque);
        }


        public string recuperarNome(string onde, string oque)
        {
            string result = "Não encontrado";
            int pos = this.buscar(onde, oque);

            if (pos >= 0)
            {
                if (onde == "autor") result = this.autores[pos].Nome;
                if (onde == "editora") result = this.editoras[pos].Nome;
            }

            return result;
        }
    }
}