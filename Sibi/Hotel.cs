﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibi
{
    internal class Hotel
    {
        // propriedades
        private string nome;
        private string cidade;
        private List<Reserva> reservas = new List<Reserva>();

        // getters/setters
        public string nome { get { return this.nome; } }
        public string cidade { get { return this.cidade; } }

        // método construtor
        public Hotel(string nom, string cida)
        {
            this.nome = nom;
            this.cidade = cida;
        }