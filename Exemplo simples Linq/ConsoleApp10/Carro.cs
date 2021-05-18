using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Carro
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }

        public int qtd;

        public Carro(string placa, string modelo, string cor, string ano) 
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;

        }
    }
}
