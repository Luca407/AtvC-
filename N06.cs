using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número decimal: ");
        decimal numero = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("O número digitado foi: " + numero);
    }
}
