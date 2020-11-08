/*Considere a seguinte situação: descontam-se inicialmente 10% do salário bruto do trabalhador como contribuição à previdência social. Após esse desconto, há um outro desconto de 5% sobre o valor restante do salário bruto, a título de um determinado imposto. Faça um algoritmo que leia o salário bruto de um cidadão e imprima o seu salário líquido.*/

using System;

namespace CalculoSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto, salarioLiquido, descontoPrevidencia, descontoImposto;

            Console.WriteLine("Informe o salário bruto: ");
            salarioBruto = int.Parse(Console.ReadLine());

            descontoPrevidencia = salarioBruto * 0.10;
            descontoImposto = salarioBruto * 0.05;
            salarioLiquido = salarioBruto - descontoPrevidencia - descontoImposto;

            Console.WriteLine("O valor do salário líquido é de: ", salarioLiquido);       
        }
        console.WriteLine("Clique em ENTER para sair");
        console.ReadLine(); 
    }
}