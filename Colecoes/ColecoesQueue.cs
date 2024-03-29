﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            //First in , first out
            var fila = new Queue<string>();

            // enfilerar
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            // aqui ele vai desinfilerar removendo o 1 item
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
            Console.WriteLine(salada.Contains("item"));
        }
    }
}
