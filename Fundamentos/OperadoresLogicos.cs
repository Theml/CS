﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 =  executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 50? {0} ", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0} ", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv de 32? {0} ", comprouTv32);

           Console.WriteLine("Mais saudável? {0} ", !comprouSorvete);
        }
    }
}
