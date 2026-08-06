using System;

class Program
{
    static void Main()
    {
        Random sorteio = new Random();
        int numeroSecreto = sorteio.Next(1, 101);

        int palpite;
        int tentativas = 0;
        const int MAX_TENTATIVAS = 7;

        Console.WriteLine("Adivinhe o número secreto (entre 1 e 100).");

        do
        {
            Console.WriteLine("Seu Palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("Muito Baixo! Tente um número maior.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("Muito alto! Tente um número menor.");
            }
            else
            {
                Console.WriteLine($"Acertou! O número era {numeroSecreto}.");
                Console.WriteLine($"Você precisou de {tentativas} tentativas.");
            }
        } while (palpite != numeroSecreto && tentativas <  MAX_TENTATIVAS);

        if (palpite != numeroSecreto )
        {
            Console.WriteLine($"Você perdeu! O número secreto era {numeroSecreto}.");
        }
    }
}