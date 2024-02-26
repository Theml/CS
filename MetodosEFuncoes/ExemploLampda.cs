using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.MetodosEFuncoes
{
    class ExemploLampda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine(" Lampda com C#! ");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString(" X ");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format(" {0:D2}/ {1:D2}/ {2:D2}", dia, mes, ano);
            Console.WriteLine(formatarData(4, 10, 1998));
        }
    }
}
