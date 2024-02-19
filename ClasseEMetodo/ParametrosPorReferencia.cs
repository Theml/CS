using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.ClasseEMetodo
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            // Maior capacidade de gerar bug em um geral por fazer alterações por referencia
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero,out int numero2)
        {
            // out é unidirecional
            numero = 0;
            numero2 = 0;
            numero = numero + 15;
            numero2 = numero2 + 30;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            AlterarOut(out int b,out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}
