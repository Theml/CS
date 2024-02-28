using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Api
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var interval = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(interval);

            Console.WriteLine("Minutos: " + interval.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + interval.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo);

            Console.WriteLine(interval.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(interval.Subtract(TimeSpan.FromMinutes(8)));
            Console.WriteLine(interval);

            Console.WriteLine("ToString 1: " + interval.ToString("g"));
            Console.WriteLine("ToString 2: " + interval.ToString("G"));
            Console.WriteLine("ToString 3: " + interval.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);
        }
    }
}
