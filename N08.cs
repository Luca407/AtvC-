using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o preço do produto: ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o percentual de desconto: ");
        double desconto = Convert.ToDouble(Console.ReadLine());

        double precoFinal = preco - (preco * desconto / 100);
        Console.WriteLine("O preço final com desconto é: " + precoFinal.ToString("F2"));
    }
}
