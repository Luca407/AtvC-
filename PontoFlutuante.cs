using System;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite algum número inteiro: ");

            // Ler a entrada do usuário como uma string.
            string input = Console.ReadLine();
            
            // Converter a string inserida para um número inteiro.
            float numero;
            if (float.TryParse(input, out numero)) 
            {
                Console.WriteLine("a resposta foi: " + numero);
            } 
            else 
            {
                Console.WriteLine("Erro! Número digitado inválido. Aperte alguma tecla para sair . . .");

            }
            Console.ReadKey(true);
        }
    }

