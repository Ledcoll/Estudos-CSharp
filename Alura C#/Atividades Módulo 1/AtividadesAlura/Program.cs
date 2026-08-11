int notaMedia;
string nomeAluno;

Console.WriteLine("Escreva seu nome!");
nomeAluno = Console.ReadLine()!;
Console.WriteLine("Olá, " + nomeAluno + "!");
Console.WriteLine(nomeAluno + " qual foi sua média final?");
notaMedia = int.Parse(Console.ReadLine()!);

void VerificarAprovacao()
{
    if (notaMedia >= 5)
    {
        Console.WriteLine("Parabéns, você foi aprovado!");
    }
    else
    {
        Console.WriteLine("Infelizmente, você não foi aprovado.");
    }
}
VerificarAprovacao();