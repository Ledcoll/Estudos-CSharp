int numeroSecreto = Random.Shared.Next(1, 10);
int numero;

Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
Console.WriteLine("Tente adivinhar o número secreto entre 1 e 10:");

numero = int.Parse(Console.ReadLine()!);

void Descobrir()
{
    switch (numero == numeroSecreto)
    {
        case true:
        {
        Console.WriteLine("Parabéns! Você descobriu o número secreto!");
            break;
        }

        case false:
        {
            if (numero < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior. Tente novamente.");
                numero = int.Parse(Console.ReadLine()!);}
            
            else if (numero > numeroSecreto)
            {
                Console.WriteLine("O número secreto é menor. Tente novamente.");
                numero = int.Parse(Console.ReadLine()!);    
            }   
        }
            break;
    }
        
}

Descobrir();


