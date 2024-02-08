using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.ClasseEMetodo
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "José";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "João";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();
        }
    }
}
