using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string vogaisValidas = "aeiou";
        int contadorVogais = 0;
        int contadorConsoantes = 0;

        foreach (char c in frase.ToLower())
        {
            if (char.IsLetter(c))
            {
                if (vogaisValidas.Contains(c))
                    contadorVogais++;
                else
                    contadorConsoantes++;
            }
        }

        string[] palavras = frase.Split(' ');
        string palavraMaisLonga = palavras[0];

        foreach (string palavra in palavras)
        {
            if (palavra.Length > palavraMaisLonga.Length)
                palavraMaisLonga = palavra;
        }

        string[] palavrasInvertidas = (string[])palavras.Clone();
        Array.Reverse(palavrasInvertidas);

        for (int i = 0; i < palavrasInvertidas.Length; i++)
        {
            string p = palavrasInvertidas[i];
            if (p.Length > 0)
            {
                palavrasInvertidas[i] = char.ToUpper(p[0]) + p.Substring(1);
            }
        }

        string fraseInvertida = string.Join(" ", palavrasInvertidas);

        Console.WriteLine();
        Console.WriteLine($"Vogais: {contadorVogais}");
        Console.WriteLine($"Consoantes: {contadorConsoantes}");
        Console.WriteLine($"Palavras: {palavras.Length}");
        Console.WriteLine($"Palavra mais longa: {palavraMaisLonga}");
        Console.WriteLine($"Frase invertida: {fraseInvertida}");
    }
}