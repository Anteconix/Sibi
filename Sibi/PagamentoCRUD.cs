﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    public class PagamentoCRUD
    {
        private double valor;
        private string tipo;
        private BancoDados bd;
        private Tela tl;
        private int posicao;


        public PagamentoCRUD(BancoDados banco, Tela tela)
        {
            this.bd = banco;
            this.tl = tela;
        }

        public void executarCRUD()
        {
            string resp;
            this.posicao = -1;

            this.montarTela();
            this.entrarCodigo();
            this.posicao = bd.buscar("Pagamento", this.codigo);

            if (this.posicao == -1)
            {
                // cadastro
                resp = tl.fazerPergunta(11, 11, "Registro NÃO encontrado. Deseja cadastrar (S/N):");
                if (resp.ToUpper() == "S")
                {
                    this.entrarDados();
                    resp = tl.fazerPergunta(11, 11, "Confirma cadastro (S/N):");
                    if (resp.ToUpper() == "S")
                    {
                        bd.gravar("Pagamento", new Pagamento(this.valor, this.tipo));
                    }
                }
            }
            else
            {
                // alteração / exclusão
                Pagamento obj = (Pagamento)bd.recuperar("Pagamento", this.posicao);
                this.valor = obj.valor;
                this.tipo = obj.tipo;

                this.mostrarDados();
                resp = tl.fazerPergunta(11, 11, "Deseja alterar/excluir/voltar (A/E/V):");
                if (resp.ToUpper() == "A")
                {
                    this.tl.limparArea(27, 9, 69, 10);
                    this.entrarDados();
                    resp = tl.fazerPergunta(11, 11, "Confirma alteração (S/N):");
                    if (resp.ToUpper() == "S")
                    {
                        Pagamento novoObj = new Pagamento(this.valor, this.tipo);
                        bd.alterar("Pagamento", obj, novoObj);
                    }
                }
                if (resp.ToUpper() == "E")
                {
                    resp = tl.fazerPergunta(11, 11, "Confirma exclusão (S/N):");
                    if (resp.ToUpper() == "S")
                    {
                        bd.excluir("Pagamento", obj);
                    }
                }
            }

        }

        public void montarTela()
        {
            tl.montarMoldura(10, 6, 70, 12, "Cadastro de Pagamento");
            Console.SetCursorPosition(11, 8);
            Console.Write("Valor        :");
            Console.SetCursorPosition(11, 9);
            Console.Write("Tipo         :");
            Console.SetCursorPosition(11, 10);
        }

        public void entrarCodigo()
        {
            Console.SetCursorPosition(27, 8);
            this.codigo = Console.ReadLine();
        }

        public void entrarDados()
        {
            Console.SetCursorPosition(27, 9);
            this.valor = Console.ReadLine();
            Console.SetCursorPosition(27, 10);
            this.tipo = Console.ReadLine();
            Console.SetCursorPosition(27, 11);
        }

        public void mostrarDados()
        {
            Console.SetCursorPosition(27, 9);
            Console.Write(this.valor);
            Console.SetCursorPosition(27, 10);
            Console.Write(this.tipo);
            Console.SetCursorPosition(27, 11);
        }
    }
}
