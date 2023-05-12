using System;
using Struct;

namespace Struct{
    class Program
    {
        static void Main(string[]args)
        {
            string escolha;

            Console.WriteLine("O que você quer:");
            escolha = Console.ReadLine();

            if(escolha == "jogador"){
            jogador jogador1 = new();

            jogador1.registrarNumeroCatoesAmarelos = "75";
            jogador1.registrarNumeroCatoesVermelhos = "3";
            jogador1.verificarVinculoClube = "PSG";
            jogador1.nomeJogador = "Neymar";
            jogador1.numeroCamisa = "10";
            jogador1.numeroGols = "540";
            jogador1.posicao = "MEI";

            Console.WriteLine(jogador1.imprimir());
            }
          else{
            if(escolha == "equipe"){

           
            equipe equipe1 = new();

            equipe1.CampeonatoVencido = "10";
           equipe1.AnoEstreia = "2010";
           equipe1.ValoresArrecados = "200.000.000.000";
           equipe1.QuantosMundial = "2";
           equipe1.ChampionsLeague = "1";
           equipe1.total(2000);

           Console.WriteLine(equipe1.imprimir());
            }
          }
          else{
            if(escolha == "produto"){

              produto produto1 = new();
              
              produto1.Produto = "Camiseta";
              produto1.ValorDesconto = "100";
              produto1.PorcentagemCupom = "10%";
              produto1.Quantidade = "5";
            }
          }
        }
    }


}
