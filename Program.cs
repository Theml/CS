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
using Learning.EstruturaDeControle;

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
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadoresTernarios.Executar},

                //Estrutura de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIF.Executar },
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar },
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar },
                {"Estrutura Foreach - Estrutura de Controle", EstruturaForeach.Executar },
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar },

                //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Construtores - Classes e Metodos", Construtores.Executar },
                {"Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar },
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributos Estaticos - Classes e Metodos", DesafioAtributo.Executar },
                {"Parâmetros - Classes e Metodos", Params.Executar },
                {"Parâmetros Nomeados - Classes e Metodos", ParametrosNomeados.Executar },
                {"Getters & Setters - Classes e Metodos", GetSet.Executar },
                {"Propriedades - Classes e Metodos", Props.Executar },
                {"Readonly - Classes e Metodos", Readonly.Executar },
                {"Enums - Classes e Metodos", ExemploEnum.Executar },
                {"Struct - Classes e Metodos", ExemploStruct.Executar },
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar },
                {"Valor Vs Referencia - Classes e Metodos", ValorVsReferencia.Executar },
                {"Parametros por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar },
                {"Out - Classes e Metodos", ExemOut.Executar },
                {"Parametro Com Valor Padrão - Classes e Metodos", ParametroPadrao.Executar },

                // Coleções
                //{"Array - Coleções", ArrayE.Executar},
                //{"List - Coleções", ColecoesList.Executar},
                //{"Array List - Coleções", ColecoesArrayList.Executar},
                //{"Set - Coleções", ColecoesSet.Executar},
                //{"Queue - Coleções", ColecoesQueue.Executar},
                //{"Igualdade - Coleções", Igualdade.Executar},
                //{"Stack - Coleções", Stack.Executar}


            });

            central.SelecionarEExecutar();
        }
    }
}