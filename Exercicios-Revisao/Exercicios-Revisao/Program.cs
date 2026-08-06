using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos termos deseja exibir? ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Erro: o número de termos deve ser maior que zero.");
            return;
        }

        long anterior = 0;
        long atual = 1;
        long soma = 0;

        Console.Write("Série de Fibonacci: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write(anterior + " ");
            soma += anterior;

            long proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        Console.WriteLine();
        Console.WriteLine($"Soma dos termos: {soma}");
    }
}