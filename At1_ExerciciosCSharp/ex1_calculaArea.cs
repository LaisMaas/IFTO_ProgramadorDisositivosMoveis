/*1) Faça um algoritmo para calcular a área de uma circunferência, considerando a fórmula ÁREA = π * RAIO². Utilize as variáveis AREA e RAIO, a constante π (pi = 3,14159) e os operadores aritméticos de multiplicação. *
0 pontos*/

using System;

namespace CalculaArea
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
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();
        }
    }
}
