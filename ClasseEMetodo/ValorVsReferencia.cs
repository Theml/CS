using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.ClasseEMetodo
{
    // No caso se alterar para struct o Dependente mudará o resultado do ultimo exemplo aplicando atribuição por valor.
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int number = 3;
            int copiaNumber = number;
            Console.WriteLine($"{number} {copiaNumber}");

            number++;
            Console.WriteLine($"{number} {copiaNumber}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDependente = dep;

            Console.WriteLine($"{dep.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDependente.Idade}");

            copiaDependente.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDependente.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDependente.Idade}");
        }
    }
}
