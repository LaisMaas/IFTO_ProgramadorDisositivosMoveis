using System;

namespace RepetirFrase
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarando as variáveis
            int contador = 0;

            do{
                console.WriteLine("A prática leva a perfeição.");
                contador = contador + 3;

            }while(contador < 12);
            console.WriteLine(contador, "Clique em ENTER para sair")
            console.ReadLine(); 


            do{
                console.WriteLine("A prática leva a perfeição.");
                contador = contador + 20;

            }while(contador < 12);
            console.WriteLine(contador, "Clique em ENTER para sair")
            console.ReadLine(); 
        } 
    }
}