﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    internal class RedeHoteis
    {
        // propriedades
        private string nome;
        private List<Hotel> hoteis = new List<Hotel>();

        // getters/setters
        public string nome { get { return this.nome; } }

        // método construtor
        public RedeHoteis(string nom)
        {
            this.nome = nom;
        }