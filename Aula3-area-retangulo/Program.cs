using System;

class AreaRetangulo
{
    static void Main(string[] args)
    {
        Console.Write("Digite a base: ");
        string entradaBase = Console.ReadLine();
        double baseRetangulo = Convert.ToDouble(entradaBase);

        Console.Write("Digite a altura: ");
        string entradaAltura = Console.ReadLine();
        double altura = Convert.ToDouble(entradaAltura);

        double area = baseRetangulo * altura;

        Console.WriteLine();
        Console.WriteLine($"Área do retângulo: {baseRetangulo} x {altura} = {area}");
    }
}