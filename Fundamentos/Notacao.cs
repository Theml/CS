﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Fundamentos
{
    class Notacao
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
