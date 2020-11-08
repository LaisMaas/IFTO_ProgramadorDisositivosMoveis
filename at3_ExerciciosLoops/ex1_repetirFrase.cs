using System;

namespace RepetirFrase
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarando as variáveis
            int contador = 0;

            while(contador < 12){
                console.WriteLine("A prática leva a perfeição.");
                contador = contador + 3;
            }
            console.WriteLine(contador, "Clique em ENTER para sair")
            console.ReadLine();    
        }
    }
}