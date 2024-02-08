using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.EstruturaDeControle
{
    class EstruturaIF
    {
        public static void Executar()
        {
            //var num1 = 2;
            //var num2 = 3;

            //if(num1 + num2 == 5)
            //{
            //    Console.WriteLine("Pudim");
            //}

            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
                
        }
    }
}
