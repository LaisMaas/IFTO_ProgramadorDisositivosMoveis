/*Construa um algoritmo que leia um número inteiro de 1 a 7 e
informe o dia da semana correspondente, sendo domingo o
dia de número 1. Se o número não corresponder a um dia da
semana, mostre uma mensagem de erro.*/


using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis
            int diaSemana;

            console.Writeline("Informe o número correspondente ao da da semana: ");
            diaSemana = int.Parse(console.ReadLine());


            //Efetuando a verificação/processamento
            switch(diaSemana){
                case 1:
                    console.Writeline("Domingo");
                    break;

                case 2:
                    console.Writeline("Segunda-feira");
                    break;

                case 3:
                    console.Writeline("Terça-feira");
                    break;

                case 4:
                    console.Writeline("Quarta-feira");
                    break;

                case 5:
                    console.Writeline("Quinta-feira");
                    break;

                case 6:
                    console.Writeline("Sexta-feira");
                    break;
    
                case 7:
                   console.Writeline("Sábado");
                   break;
                default:
                    console.log("O valor informado é inválido");
                    break;
            }
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();              
        }
    }
}