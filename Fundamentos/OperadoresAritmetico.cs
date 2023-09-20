using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Fundamentos
{
    class OperadoresAritmetico
    {
        public static void Executar()
        {
            //Desconto
            var preco = 1500.0;
            var imposto = 450;
            var desconto = 0.45;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é :{0}", totalComDesconto);

            //IMC
            double peso = 55.78;
            double altura = 1.75;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // Numero Par/ Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
