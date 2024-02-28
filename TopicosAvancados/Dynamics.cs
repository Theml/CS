using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"O/A aluno(a) {aluno.nome} de {aluno.idade} anos tirou {aluno.nota} na prova");
        }
    }
}
