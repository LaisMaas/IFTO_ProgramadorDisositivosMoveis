/*Faça um algoritmo que leia uma temperatura em graus Celsius e apresente-a convertida em graus Fahrenheit. A fórmula de conversão é: F = (9 * C + 160) / 5, na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius.*/

using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausCelsius, grausFahrenheit;

            Console.WriteLine("---------Conversão de graus Celsius em graus Fahrenheit----------");
            Console.WriteLine("Informe os graus em Celsius que deseja converter:");
            grausCelsius = double.Parse(Console.ReadLine());

            grausFahrenheit = (9 * grausCelsius + 160) / 5;

            Console.WriteLine("Os graus convertido em Fahrenheit e´: {0}", grausFahrenheit);

        }
    }
}