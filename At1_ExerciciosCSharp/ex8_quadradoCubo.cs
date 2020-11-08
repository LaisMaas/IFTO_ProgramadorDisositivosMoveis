/*Faça um algoritmo que leia um valor inteiro e apresente os resultados do quadrado e do cubo do valor lido.*/

using System;

namespace QuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorReferencia, quadrado, cubo;

            Console.WriteLine("Informe o valor de referência para o cálculo do quadrado e do cubo do número: ");
            valorReferencia = int.Parse(Console.ReadLine());

            quadrado = valorReferencia * 2;
            cubo = valorReferencia * 3;


            Console.WriteLine("Número informado: ", valorReferencia);
            Console.WriteLine("\n O valor do quadrado: ", quadrado);
            Console.WriteLine("\n O valor do cubo: ", cubo);
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();       
        }
    }
}
