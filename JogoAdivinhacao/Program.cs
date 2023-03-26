namespace JogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatório = random.Next(1, 21);
            int pontuacao = 1000;
            int chances = 15;

            Console.WriteLine("***************************************");
            Console.WriteLine("* Bem-vindo ao jogo de adivinhação! *");
            Console.WriteLine("***************************************");

            // Escolhendo o nível de dificuldade
            Console.WriteLine();
            Console.WriteLine("Escolha o nível de dificuldade: ");
            Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
            Console.WriteLine("Escolha: ");
            int nivel = int.Parse(Console.ReadLine());

            if (nivel == 2)
            {
                chances = 10;
            }
            else if (nivel == 3)
            {
                chances = 5;
            }

            // Loop para adivinhar o número
            while (chances > 0)
            {
                Console.WriteLine("Você tem {0} chances. Qual o seu chute?", chances);
                int numeroChutado = int.Parse(Console.ReadLine());

                if (numeroChutado == numeroAleatório)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    Console.WriteLine("Sua pontuação final é: {0}", pontuacao);
                    break;
                }
                else if (numeroChutado < numeroAleatório)
                {
                    Console.WriteLine("Seu chute foi menor que o número secreto!");
                }
                else
                {
                    Console.WriteLine("Seu chute foi maior que o número secreto!");
                }

                pontuacao -= Math.Abs((numeroChutado - numeroAleatório) / 2);

                chances--;
            }

            if (chances == 0)
            {
                Console.WriteLine("Você perdeu todas as suas chances. O número era: {0}", numeroAleatório);
                Console.WriteLine("Sua pontuação final é: {0}", pontuacao);
            }

            Console.ReadLine();
        }
    }
}