﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEObjetos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
//using CursoCSharp.Testes;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
         static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                
                // Curso CSharp - Fundamentos 
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos",Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos",OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos",OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos",OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos",OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos",OperadorTernario.Executar},
                
                // Curso CSharp - Estrutura de Controle
                {"Estrutura If - Estrutura de Controle",EstruturaIf.Executar},
                {"Estrutura If Else - Estrutura de Controle",EstruturaIfElse.Executar},
                {"Estrutura If Else If - Estrutura de Controle",EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle",EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle",EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle",EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle",EstruturaFor.Executar},
                {"Estrutura For Each - Estrutura de Controle",EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle",UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle",UsandoContinue.Executar},

                // Curso CSharp - Classes & Objetos
                {"Membros - Classes e Metodos ",Membros.Executar},
                {"Construtores - Classes e Metodos ",Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos ",MetodoComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos ",MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos ",AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos ",DesafioAtributo.Executar},
                {"Params - Classes e Metodos ",Params.Executar},
                {"Parametros Nomeados - Classes e Metodos ",ParametrosNomeados.Executar},
                {"Get e Set - Classes e Metodos ",GetSet.Executar},
                {"Propriedades - Classes e Metodos ",Props.Executar},
                {"ReadOnly - Classes e Metodos ",ReadOnly.Executar},
                {"Exemplo Enum - Classes e Metodos ",ExemploEnum.Executar},
                {"Struct - Classes e Metodos ",ExemploStruct.Executar},
                {"Struct vs Class - Classes e Metodos ",StructVsClass.Executar},
                {"Valor vs Referencia - Classes e Metodos ",ValorVsReferencia.Executar},
                {"Parametros por Referência - Classes e Metodos ", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos ", ParametroPadrao.Executar},

                // Curso CSharp - Coleções
                {"Array - Coleções ", Colecoes.Array.Executar},
                {"List - Coleções ", ColecoesList.Executar},
                {"Array List - Coleções ", ColecoesArrayList.Executar},
                {"Set - Coleções ", ColecoesSet.Executar},
                {"Queue - Coleções ", ColecoesQueue.Executar},
                {"Igualdade - Coleções ", Igualdade.Executar},
                {"Dictionary - Coleções ", ColecoesDictionary.Executar},
                
                // Curso CSharp - OO
                {"Herança - OO ", Heranca.Executar},
                {"Construtor This - OO ", ConstrutorThis.Executar},
                {"Encapsulamento - OO ", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO ", OO.Polimorfismo.Executar},
                {"Abstract - OO ", OO.Abstract.Executar},
                {"Interface - OO ", OO.Interface.Executar},
                {"Sealead - OO ", OO.Sealed.Executar},
                
                //Métodos & Funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegates - Métodos & Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos & Funções", UsandoDelegate.Executar},
                {"Delegate Func Anonima - Métodos & Funções", DelegateFuncAnonima.Executar},
                {"Delegates Como Parametros - Métodos & Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensao - Métodos & Funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //Api
                {"Primeiro Arquivo - Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Api", LendoArquivos.Executar},
                {"Exemplo File Info - Api", ExemploFileInfo.Executar},
                {"Diretorios - Api", Diretorios.Executar},
                {"Exemplos Directory Info - Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Api", ExemploPath.Executar},
                {"Exemplo DateTime - Api", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Api", ExemploTimeSpan.Executar},


                //Topicos Avançados
                {"LINQ 1 - Topicos Avançados", LINQ1.Executar},
                {"LINQ 2 - Topicos Avançados", LINQ2.Executar},
                {"Nullables - Topicos Avançados", Nullables.Executar},
                {"Dynamic - Topicos Avançados", Dynamic.Executar},
                {"Generics - Topicos Avançados", Generics.Executar},

                //Testes
                //{"Code Test  - Testes", CodeTest.Executar},




            });

            central.SelecionarEExecutar();
        }
    }
}