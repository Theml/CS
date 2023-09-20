using System;
using System.Collections.Generic;

//using Learning.OO;
//using Learning.Api;
//using Learning.Excecoes;
using Learning.Colecoes;
using Learning.Fundamentos;
using Learning.ClasseEMetodo;
//using Learning.MetodosEFuncoes;
//using Learning.TopicosAvancados;
//using Learning.EstruturaDeControle;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeira Coisa - Fundamentos", FirstThing.Executar},
                {"Comentário - Fundamentos", Comments.Executar},
                {"Variaveis & Constantes - Fundamentos", Variavel.Executar},
                {"Inferencia & Tipos - Fundamentos", Inferencia.Executar},
                {"Iterpolação de string - Fundamentos", Interpolacao.Executar},
                {"Notação - Fundamentos", Notacao.Executar},
                {"Lendos Dados - Fundamentos", Dados.Executar},
                {"Formatação de Numero - Fundamentos", Formatando.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operações Aritimeticas - Fundamentos", OperadoresAritmetico.Executar},
                {"Operações Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operações Logicos - Fundamentos", OperadoresLogicos.Executar},

                //Estrutura de Controle

                //Classes e Metodos
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar },

                // Coleções
                {"Array - Coleções", ArrayE.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", Stack.Executar}


            });

            central.SelecionarEExecutar();
        }
    }
}