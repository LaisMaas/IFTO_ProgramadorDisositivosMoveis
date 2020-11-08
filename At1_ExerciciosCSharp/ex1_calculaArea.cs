/*1) Faça um algoritmo para calcular a área de uma circunferência, considerando a fórmula ÁREA = π * RAIO². Utilize as variáveis AREA e RAIO, a constante π (pi = 3,14159) e os operadores aritméticos de multiplicação. *
0 pontos*/

class Program
    {
        static void Main(string[] args)
        {
			double raio, area;

			Console.WriteLine("Informe o valor do raio da circunferência: ");
			raio = double.Parse(Console.ReadLine());

			area = Math.Pow(raio, 2) * 3.14;

			Console.WriteLine("A área do círculo é: {0} ", area);	
            
        }
    }
}
