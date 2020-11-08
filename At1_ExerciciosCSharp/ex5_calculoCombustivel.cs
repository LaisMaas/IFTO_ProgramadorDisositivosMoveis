/*Faça um algoritmo que calcule a quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média durante ela. Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, tempo gasto na viagem, a distância percorrida e a quantidade de litros utilizada na viagem.*/

using System;

namespace CalculoCombustivel.
{
    class Program
    {
        static void Main(string[] args)
        {
            int litrosGastos, distanciaPercorrida, tempoP, velocidadeMedia;

            Console.WriteLine("Informe o tempo de percurso em minutos: ");
            tempoP = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade média no percurso: ");
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoP * velocidadeMedia;
            litrosGastos = distanciaPercorrida / 12;

            Console.WriteLine("A quantidade de litros de combustível consumido no trajeto foi de: {0}", velocidadeMedia);
            Console.WriteLine("A quantidade de litros de combustível consumido no trajeto foi de: {0}", tempoP);
            Console.WriteLine("A quantidade de litros de combustível consumido no trajeto foi de: {0}", distanciaPercorrida);
            Console.WriteLine("A quantidade de litros de combustível consumido no trajeto foi de: {0}", litrosGastos);
            console.WriteLine("Clique em ENTER para sair")
            console.ReadLine();
        }
    }
}
