using System;

	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um caractere: ");
            
           
            char caractere = Console.ReadKey().KeyChar;
            
            
            Console.WriteLine("\nO caractere digitado foi: " + caractere);
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
		}
	}
