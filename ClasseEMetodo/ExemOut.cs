using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.ClasseEMetodo
{
    class ExemOut
    {
        public static void Executar()
        {
            // Exemplo 1
            string str = "100";
            if (int.TryParse(str, out int num))
            {
                Console.WriteLine("{0}", num + 1);
            }
            else
            {
                Console.WriteLine("A conversão falhou!");
            }

            // Exemplo 2
            double calcularMedia(double nota1, double nota2, double nota3, out String conc)
            {
                double media = (nota1 + nota2 + nota3) / 3;
                conc = media >= 7 ? "aprovado" : "reprovado";
                return media;
            }

            String conceito;
            double mediaDoAluno = calcularMedia(1.6, 9.4, 5.0, out conceito);
            Console.WriteLine("A media é " + mediaDoAluno + " e o aluno está " + conceito);
        }
    }
}
