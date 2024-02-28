using System;
using System.IO;

namespace Learning.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutes: " + diaAtual.Minute);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd")); 
            Console.WriteLine(diaAtual.ToString("d")); 
            Console.WriteLine(diaAtual.ToString("D")); 
            Console.WriteLine(diaAtual.ToString("g")); 
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("dd-mm-yyyy HH:mm"));
        }
    }
}
