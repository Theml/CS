using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.EstruturaDeControle
{
    class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Números inpares entre 1 e {0}! ", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 != 1)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Os números pares entre 1 e {0}!", intervalo);

            for (int i = 2; i <= intervalo; i += 2)
            {
                Console.Write(i + " ");    
            }
        }
    }
}
