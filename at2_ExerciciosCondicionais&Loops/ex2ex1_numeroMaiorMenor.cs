using System;

namespace ConsoleApp5

/*Crie um programa que lê dois números e retorne maior, menor ou iguais*/
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarando as variáveis
            int num1, num2;

            //Efetuando a operação da média
            console.WriteLine("Informe um número inteiro: ");
            num1 = int.Parse(console.ReadLine());

            console.WriteLine("Informe um outro número inteiro: ");
            num2 = int.Parse(console.ReadLine());


            //Atribuindo a condicional a regra relacionada a média para ve rificar se aluno aprovado, em recuperação ou reprovado. 
            if(num1 > num 2){
                console.WriteLine("O mumero ${0} é 'maior' que o número ${1}.", num1, num2);

            }else if(num1 < num2){
                console.WriteLine("O mumero ${0} é 'menor' que o número ${1}.", num1, num2);

            }else{
                console.WriteLine("O mumero ${0} é igual ao número ${1}.", num1, num2);
            }
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();         
        }
    }
}