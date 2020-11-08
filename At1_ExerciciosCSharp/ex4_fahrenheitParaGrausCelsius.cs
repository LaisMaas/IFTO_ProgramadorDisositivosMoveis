/*Faça um algoritmo que leia uma temperatura em Fahrenheit e a apresente convertida em graus Celsius. A fórmula de conversão é C = (F – 32) * (5 / 9), na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius.*/


using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausFahrenheit, grausCelsius;

            Console.WriteLine("Informe os graus em Fahrenheit que deseja converter: ");
            grausFahrenheit = double.Parse(Console.ReadLine());

            grausCelsius = (grausFahrenheit - 32) * (5 / 9);

            Console.WriteLine("Os graus convertido em graus Celsius e´ {0}", grausCelsius);
        }
    }
}
