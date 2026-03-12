//1. Crie um programa para calcular o volume de uma caixa retangular

System.Console.Write("Digite o comprimento do retangulo: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());


System.Console.Write("Digite o altura do retangulo: ");
decimal altura = Convert.ToDecimal(Console.ReadLine());


System.Console.Write("Digite o largura do retangulo: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

decimal volume = largura * altura * comprimento;

System.Console.WriteLine("O volume e: " + volume);