using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Fundamentos
{
    class Variavel
    {
        public static void Executar()
        {
            // area da circuferencia .          
            double raio = 4.5;

            const double PI = 3;

            raio = 3.5;
            //PI = 3.1415;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine();
            Console.WriteLine("A area é :" + area);

            // Tipos internos.
            bool Chovendo = true;
            Console.WriteLine();
            Console.WriteLine("Está chovendo hoje " + Chovendo);

            byte idade = 45;
            Console.WriteLine();
            Console.WriteLine("João tem " + idade + " anos");

            sbyte saldoDeCartao = sbyte.MinValue;
            Console.WriteLine();
            Console.WriteLine("O saldo do cartão é :" + saldoDeCartao);

            short Pendencia = short.MaxValue;
            Console.WriteLine();
            Console.WriteLine("O valor que deve ser esperado é :" + Pendencia);

            int menorValorInt = int.MinValue;
            Console.WriteLine();
            Console.WriteLine("O menor int é = " + menorValorInt);

            uint populacaoDoBrasil = 207_600_000;
            Console.WriteLine();
            Console.WriteLine("População do BR :" + populacaoDoBrasil);

            long menorLong = long.MinValue;
            Console.WriteLine();
            Console.WriteLine("menor long =" +  menorLong);

            ulong PopMundial = 7_600_000_000;
            Console.WriteLine();
            Console.WriteLine("populção mundial é" + PopMundial);

            float precoComputador = 3100.00f;
            Console.WriteLine();
            Console.WriteLine("O preço do computador é :" + precoComputador);

            double batata = 10000000000000.00;
            Console.WriteLine();
            Console.WriteLine("Apple :" + batata);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine();
            Console.WriteLine("A distancia entre as estrelas é :" + distanciaEntreAsEstrelas);

            char letra = 'B';
            Console.WriteLine();
            Console.WriteLine("Letra" + letra);

            string texto = "So quero dormir ;-;";
            Console.WriteLine();
            Console.WriteLine(texto);
        }
    }
}
