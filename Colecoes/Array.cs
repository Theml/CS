using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Colecoes
{
    class ArrayE
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Larissa";
            alunos[1] = "Carlos";
            alunos[2] = "Daniel";
            alunos[3] = "Emanuel";
            alunos[4] = "Luis";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7,4.8,4.2,8.2,6.7 };

            foreach(var nota in notas)
            {
                somatorio += nota;
            }
            // forma de fazer diferente do foreach
            //for(int i = 0; i < notas.Length; i++)
            //{
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
