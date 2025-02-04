using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Console.WriteLine("A palavra '" + palavra + "' tem " + palavra.Length + " caracteres.");
    }
}
