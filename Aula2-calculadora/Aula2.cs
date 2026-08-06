using System;

class Calculadoraq
{
    static void Main2(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        string entrada1 = Console.ReadLine();
        double numero1 = Convert.ToDouble(entrada1);

        Console.Write("Digite o segundo número: ");
        string entrada2 = Console.ReadLine();
        double numero2 = Convert.ToDouble(entrada2);

        double soma = numero1 + numero2;
        double subtracao = numero1 - numero2;
        double multiplicacao = numero1 * numero2;
        double divisao = numero1 / numero2;

        Console.WriteLine();
        Console.WriteLine("Resultados:");
        Console.WriteLine($"Soma: {numero1} + {numero2} = {soma}");
        Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao}");
        Console.WriteLine($"Multiplicação: {numero1} * {numero2} = {multiplicacao}");

        if (numero2 != 0)
        {
            Console.WriteLine($"Divisão: {numero1} / {numero2} = {divisao}");
        }
        else
        {
            Console.WriteLine("Divisão: não é possível dividir por zero!");
        }
    }
}