using System;
using System.Collections.Generic;

using Learning.OO;
using Learning.Api;
using Learning.Excecoes;
using Learning.Colecoes;
using Learning.Fundamentos;
using Learning.ClasseEMetodo;
using Learning.MetodosEFuncoes;
using Learning.TopicosAvancados;
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
                {"Array - Coleções", ArrayE.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                //Orientação a Objeto(OO)
                {"Herança - Orientação a Objeto", Heranca.Executar},
                {"Construtor - Orientação a Objeto", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objeto", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objeto", Polimorfismo.Executar},
                {"Classe Abstrata - Orientação a Objeto", ClasseAbstrata.Executar},
                {"Interface - Orientação a Objeto", Interface.Executar},
                {"Classe e Metodo Sealed - Orientação a Objeto", Sealed.Executar},

                //Metodos e Funções
                {"Exemplo Lampda - Metodos e Funções", ExemploLampda.Executar },
                {"Delegate com Lampda - Metodos e Funções", DelegateLampda.Executar },
                {"Usando Delegate - Metodos e Funções", UsandoDelegate.Executar },
                {"Delegate com Funções Anonimas - Metodos e Funções", DelegateFuncAnonimas.Executar },
                {"Delegate como Parametros - Metodos e Funções", DelegateComoParametros.Executar },
                {"Metodos de Extensão - Metodos e Funções", MetodosDeExtensao.Executar },

                //Exceções 
                {"Exceções e Tratamento de Erro - Exceções", ExcecaoETratamento.Executar },
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },

                //Api
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar },
                {"Lendo Arquivo - Usando API", LendoArquivo.Executar },
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar },
                {"Diretorios - Usando API", Diretorios.Executar },
                {"Diretory Info - Usando API", ExemploDirectoryInfo.Executar },
                {"Usando Path - Usando API", UsandoPath.Executar },
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar },
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar },

                //Topicos Avançados
                {"LINQ #01 - Topicos Avançados", LINQ1.Executar },
                {"LINQ #02 - Topicos Avançados", LINQ2.Executar },
                {"Nullables - Topicos Avançados", Nullables.Executar },
                {"Dynamics - Topicos Avançados", Dynamics.Executar },
                {"Generics - Topicos Avançados", Genericos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}