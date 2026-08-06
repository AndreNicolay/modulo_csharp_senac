using System;


class Aula
{
    static void Main1()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade <= 20)
        {
            Console.WriteLine($"Olá {nome}, você é novo.");
        } else if (idade <= 35)
        {
            Console.WriteLine($"Olá {nome}, você é jovem.");
        } else
        {
            Console.WriteLine($"Olá {nome}, você é velho.");
        }

        Console.WriteLine($"Olá {nome}!");
        Console.WriteLine($"Você tem {idade} anos.");
    }
}