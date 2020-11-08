/*Faça um algoritmo que leia os valores de COMPRIMENTO, LARGURA e ALTURA e apresente o valor do volume de uma caixa retangular. Utilize para o cálculo a fórmula VOLUME = COMPRIMENTO * LARGURA * ALTURA.*/

using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura, altura, volume;

            Console.WriteLine("Informe o comprimento do objeto: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a largura do objeto: ");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do objeto: ");
            altura = double.Parse(Console.ReadLine());

            volume = comprimento * altura * largura;

            Console.WriteLine("O volume deste objeto é: ", volume);
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();
        }
    }
}

