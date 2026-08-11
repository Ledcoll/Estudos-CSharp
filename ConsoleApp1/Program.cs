using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine ("- Olá, seja bem vindo!");

            Console.WriteLine ("(PRESSIONE QUALQUER TECLA PARA CONTINUAR)");
            Console.ReadKey(true);
            

            Console.WriteLine("- Que tal nós coletarmos algumas informações de você para personalizar sua experiência?");

            Console.WriteLine ("(PRESSIONE QUALQUER TECLA PARA CONTINUAR)");
            Console.ReadKey(true);

            Console.WriteLine("Por favor me diga seu nome?");
            string Nome = Console.ReadLine();
            

            Console.WriteLine(Nome + " para prosseguirmos poderia nos informar sua idade?");
            int Idade = Convert.ToInt16(Console.ReadLine());

            if (Idade < 18)
            {
                Console.WriteLine( Nome + " você é menor de idade, portanto não poderá prosseguir. Obrigado pelo seu acesso");

                Console.WriteLine ("(PRESSIONE QUALQUER TECLA PARA FECHAR)");

                Console.ReadKey();

                Console.Clear();
            }

            if (Idade >= 18)
            {
            Console.WriteLine (Nome + " você tem " + Idade + " anos de idade, portanto poderá prosseguir!" );
            Console.WriteLine ("(PRESSIONE QUALQUER TECLA PARA CONTINUAR)");
            Console.ReadKey();
            }
            string sim = "sim";
            string não = "não";
            Console.WriteLine ("Você gosta de jogos?");
            Console.WriteLine ( sim );
            Console.WriteLine ( não );
            string Resposta = Console.ReadLine();
            

        if ( Resposta == sim)
        {
        Console.WriteLine ("quais jogos você costuma jogar?");
        string RespostaJogo = Console.ReadLine();
        Console.WriteLine ("ótimo! Adoramos jogar " + RespostaJogo + " também!" );
        Console.ReadKey();
        }
        else 
        {
            Console.Write ("tudo bem! Acabamos por aqui. Seu nome é " + Nome + ", tem " + Idade + " anos de idade e não gosta de jogos.");
            Console.ReadLine();
        }
            
        }
    }
}