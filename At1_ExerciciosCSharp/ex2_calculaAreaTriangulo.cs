/*Faça um algoritmo que calcule a área de um triângulo, considerando a fórmula ÁREA = (BASE * ALTURA)/2. Utilize as variáveis AREA, BASE e ALTURA e os operadores aritméticos de multiplicação e divisão. */

using System;

namespace calculaAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaT;
            double baseT;
            double alturaT;


            Console.WriteLine("Informe a base do trinângulo: ");
            baseT = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do trinângulo: ");
            alturaT = double.Parse(Console.ReadLine());

            areaT = (baseT * alturaT) / 2;

            Console.WriteLine("A área do triângulo é: {0}", areaT);

        }
    }
}