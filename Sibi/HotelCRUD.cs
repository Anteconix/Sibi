﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    public class HotelCRUD
    {
        private string nome, cidade;
        private BancoDados bd;
        private Tela tl;
        private int posicao;


        public HotelCRUD(BancoDados banco, Tela tela)
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
            this.posicao = bd.buscar("Hotel", this.codigo);

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
                        bd.gravar("Hotel", new Hotel(this.nome, this.cidade));
                    }
                }
            }
            else
            {
                // alteração / exclusão
                Hotel obj = (Hotel)bd.recuperar("Hotel", this.posicao);
                this.nome = obj.nome;
                this.cidade = obj.cidade;

                this.mostrarDados();
                resp = tl.fazerPergunta(11, 11, "Deseja alterar/excluir/voltar (A/E/V):");
                if (resp.ToUpper() == "A")
                {
                    this.tl.limparArea(27, 9, 69, 10);
                    this.entrarDados();
                    resp = tl.fazerPergunta(11, 11, "Confirma alteração (S/N):");
                    if (resp.ToUpper() == "S")
                    {
                        Hotel novoObj = new Hotel(this.nome, this.cidade);
                        bd.alterar("Hotel", obj, novoObj);
                    }
                }
                if (resp.ToUpper() == "E")
                {
                    resp = tl.fazerPergunta(11, 11, "Confirma exclusão (S/N):");
                    if (resp.ToUpper() == "S")
                    {
                        bd.excluir("Hotel", obj);
                    }
                }
            }

        }

        public void montarTela()
        {
            tl.montarMoldura(10, 6, 70, 12, "Cadastro de Hotel");
            Console.SetCursorPosition(11, 8);
            Console.Write("Nome        :");
            Console.SetCursorPosition(11, 9);
            Console.Write("Cidade         :");
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
            this.nome = Console.ReadLine();
            Console.SetCursorPosition(27, 10);
            this.cidade = Console.ReadLine();
            Console.SetCursorPosition(27, 11);
        }

        public void mostrarDados()
        {
            Console.SetCursorPosition(27, 9);
            Console.Write(this.nome);
            Console.SetCursorPosition(27, 10);
            Console.Write(this.cidade);
            Console.SetCursorPosition(27, 11);
        }
    }
}
