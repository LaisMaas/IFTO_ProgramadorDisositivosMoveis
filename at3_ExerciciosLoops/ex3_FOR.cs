using System;

namespace RepetirFrase
{
    class Program
    {
        static void Main(string[] args)
        {

            //A variável pode ser declarada diretamente no teste do laço FOR (local), mas se ne cessário também pode ser declarada no escopo global do código
            for( int i = 0; i < 12; i = i + 3){
                console.WriteLine("A prática leva a perfeição.");                
            }
            console.WriteLine(i, "Clique em ENTER para sair")
            console.ReadLine();  

            
            //A composição do teste no FOR é da inicialização + condição + incremento        
            for( int i = 0; i < 12; i = i ++){
                console.WriteLine("Quem espera sempre se cansa.");                
            }
            console.WriteLine(i, "Clique em ENTER para sair")
            console.ReadLine();
        }
    }
}