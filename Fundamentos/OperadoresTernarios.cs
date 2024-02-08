using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Fundamentos
{
    class OperadoresTernarios
    {
        public  static  void Executar()
        {
            var nota = 10.0;
            var bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado"; 
            // como retorna uma string pode ser usado string no lugar de var
            Console.WriteLine(resultado);

        }
    }
}
