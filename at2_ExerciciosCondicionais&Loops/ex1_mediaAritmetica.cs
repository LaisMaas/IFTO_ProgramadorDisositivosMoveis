using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarando as variáveis
            double media, nota1, nota2, nota3, nota4;

            console.Writeline("Informe a nota1: ");
            nota1 = double.Parse(console.ReadLine());

            console.Writeline("Informe a nota2: ");
            nota1 = double.Parse(console.ReadLine());

            console.Writeline("Informe a nota3: ");
            nota1 = double.Parse(console.ReadLine());

            console.Writeline("Informe a nota4: ");
            nota1 = double.Parse(console.ReadLine());


            //Efetuando a operação da média
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            

            //Atribuindo a condicional a regra relacionada a média para ve rificar se aluno aprovado, em recuperação ou reprovado. 
            if(media >= 7){
                console.WriteLine("A média é de:{0} . Parabéns, você foi aprovado!", media);

            }else if(media < 7 && media >=5){
                console.WriteLine("A média é de:{0} . Você está em recuperação.", media);

            }else{
                console.WriteLine("A média é de:{0} . Infelizmente você foi reprovado.", media);

            }
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();         
        }
    }
}