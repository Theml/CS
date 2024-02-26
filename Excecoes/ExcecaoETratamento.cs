using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }

    class ExcecaoETratamento
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            //var conta2 = new Conta(2000);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            } catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally // so é utilizado em caso de você tiver algo para vir garantido após a exceção .
            {
                Console.WriteLine("Obrigado!");
            }

            //try
            //{
            //    conta2.Sacar(1500);
            //    Console.WriteLine("Retirada com sucesso!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Obrigado!");
            //}
        }
    }
}
