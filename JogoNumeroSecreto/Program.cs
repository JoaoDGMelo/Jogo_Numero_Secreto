//Jogo do Número Secreto

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 10);
bool ganhou = false;
int numeroDeChutes = 0;

void Apresentacao()
{
    numeroSecreto = aleatorio.Next(1, 10);
    ganhou = false;
    numeroDeChutes = 0;

    Console.WriteLine(@"
███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░  ░██████╗███████╗░█████╗░██████╗░███████╗████████╗░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗  ██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║  ╚█████╗░█████╗░░██║░░╚═╝██████╔╝█████╗░░░░░██║░░░██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║  ░╚═══██╗██╔══╝░░██║░░██╗██╔══██╗██╔══╝░░░░░██║░░░██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝  ██████╔╝███████╗╚█████╔╝██║░░██║███████╗░░░██║░░░╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░░╚════╝░
");
    Console.WriteLine("Bem Vindo ao jogo do número secreto!\nEstou pensando em um número entre 1 e 10...consegue adivinhar qual é?\n");

    LoopDoJogo();
}

void LoopDoJogo()
{
    do
    {
        numeroDeChutes++;
        Console.Write("Digite seu palpite: ");
        int chute = int.Parse(Console.ReadLine()!);

        if (chute == numeroSecreto)
        {
            Console.WriteLine($"\nVOCÊ ACERTOU!!!\nO número era {numeroSecreto}");
            Console.WriteLine($"Você chutou um total de {numeroDeChutes} vezes.");
            ganhou = true;
        }
        else if (chute < numeroSecreto)
        {
            Console.WriteLine($"\nERROOOOU\nEste não é o número...\nO número é maior que {chute}\n");
        }
        else if (chute > numeroSecreto)
        {
            Console.WriteLine($"\nERROOOOU\nEste não é o número...\nO número é menor que {chute}\n");
        }
    } while (ganhou == false);

    JogarNovamente();
}

void JogarNovamente()
{
    Console.WriteLine("\nVocê gostaria de jogar novamente?\n\n1. Sim!\n2. Não, obrigado.");
    Console.Write("Sua escolha é: ");
    int jogarNovamente = int.Parse(Console.ReadLine()!);

    if (jogarNovamente == 1)
    {
        Console.Clear();
        Apresentacao();
    }
    else if (jogarNovamente == 2)
    {
        Console.WriteLine("Certo, vamos encerrar o jogo então.\nObrigado!");
    }
    else
    {
        Console.WriteLine("Não entendi sua escolha...");
        JogarNovamente();
    }
}

Apresentacao();