using System;
using System.Globalization;

namespace Learning.Fundamentos
{
    class Formatando
    {
        public static void Executar()
        {
            double value = 15.75;
            // Formas de Formatação
            Console.WriteLine(value.ToString("F1"));
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine(value.ToString("P"));
            Console.WriteLine(value.ToString("#.##")); // aqui poderia trocar por F2 também

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(value.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
