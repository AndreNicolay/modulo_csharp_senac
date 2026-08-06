using System;

class Program
{
    static void Main()
    {
        string[] meses = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun",
                           "Jul", "Ago", "Set", "Out", "Nov", "Dez" };
        double[] vendas = new double[12];

        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Vendas de {meses[i]}: ");
            vendas[i] = double.Parse(Console.ReadLine());
        }

        double total = CalcularTotal(vendas);
        double media = total / vendas.Length;
        int indiceMaior = EncontrarIndiceMaior(vendas);
        int indiceMenor = EncontrarIndiceMenor(vendas);
        int acimaDaMedia = ContarAcimaDaMedia(vendas, media);
        double variacao = CalcularVariacaoPercentual(vendas[indiceMaior], vendas[indiceMenor]);

        Console.WriteLine();
        Console.WriteLine($"Total anual: R$ {total:F2}");
        Console.WriteLine($"Média mensal: R$ {media:F2}");
        Console.WriteLine($"Melhor mês: {meses[indiceMaior]} (R$ {vendas[indiceMaior]:F2})");
        Console.WriteLine($"Pior mês: {meses[indiceMenor]} (R$ {vendas[indiceMenor]:F2})");
        Console.WriteLine($"Meses acima da média: {acimaDaMedia}");
        Console.WriteLine($"Variação percentual entre melhor e pior mês: {variacao:F2}%");
    }

    static double CalcularTotal(double[] v)
    {
        double soma = 0;
        foreach (double valor in v)
        {
            soma += valor;
        }
        return soma;
    }

    static int EncontrarIndiceMaior(double[] v)
    {
        int indiceMaior = 0;
        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] > v[indiceMaior])
                indiceMaior = i;
        }
        return indiceMaior;
    }

    static int EncontrarIndiceMenor(double[] v)
    {
        int indiceMenor = 0;
        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] < v[indiceMenor])
                indiceMenor = i;
        }
        return indiceMenor;
    }

    static int ContarAcimaDaMedia(double[] v, double media)
    {
        int contador = 0;
        foreach (double valor in v)
        {
            if (valor > media)
                contador++;
        }
        return contador;
    }

    static double CalcularVariacaoPercentual(double maior, double menor)
    {
        return ((maior - menor) / menor) * 100;
    }
}