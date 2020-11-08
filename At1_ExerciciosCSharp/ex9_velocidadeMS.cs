/*Faça um algoritmo que leia a velocidade de um veículo em km/h e calcule e imprima a velocidade em m/s (metros por segundo).*/

using System;

namespace VelocidadeMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int velocidadeK;
            double velocidadeM;

            Console.WriteLine("Informe a velocidade percorrida em km/h: ");
            velocidadeK = int.Parse(Console.ReadLine());

            velocidadeM = velocidadeK / 3.6;

            Console.WriteLine("A  velocidade média do percurso foi de: ", velocidadeM);
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine(); 
        }
    }
}