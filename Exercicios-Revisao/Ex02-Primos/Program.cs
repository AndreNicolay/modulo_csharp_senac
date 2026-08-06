using System;

class Program
{
    static void Main()
    {
        Console.Write("Início do intervalo: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Fim do intervalo: ");
        int fim = int.Parse(Console.ReadLine());

        Console.Write("Números primos: ");
        int contador = 0;

        for (int numero = inicio; numero < fim; numero++)
        {
            if (numero < 2)
                continue;

            bool ehPrimo = true;

            for (int divisor = 2; divisor < numero; divisor++)
            {
                if (numero %  divisor == 0)
                {
                    ehPrimo = false; 
                    break;
                }
            }

            if (ehPrimo)
            {
                Console.Write(numero + " ");
                contador++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Total de primos encontrados: {contador}");
    }
}