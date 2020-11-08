/*Faça um algoritmo que leia dois valores para as variáveis A e B e efetue a troca dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresente os valores trocados.*/

using System;

namespace TrocaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, variavelAux;

            Console.WriteLine("Informe o valor do número 1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do número 2: ");
            num2 = int.Parse(Console.ReadLine());

            variavelAux = num1;
            num1 = num2;
            num2 = variavelAux;

            Console.WriteLine("A ordem inversa dos números informados são: {0} {1}", num1, num2);
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();
        }
    }
}