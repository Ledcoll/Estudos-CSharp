//Screen Sound
using System.ComponentModel;

string welcome= "\nWelcome to Screen Sound!";

List<string> bands = new List<string>();

void WelcomeMessage()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(welcome); 
}

void Menu()
{
    Console.WriteLine("\nPress 1 to register a new band.");
    Console.WriteLine("Press 2 to list all bands.");
    Console.WriteLine("Press 3 to review a band.");
    Console.WriteLine("Press 4 to see the average rating of a band.");
    Console.WriteLine("Press -1 to exit.");

    Console.Write("\nEnter your choice: ");
    string choice = Console.ReadLine()!;
    int userChoice = int.Parse(choice);
  
  switch (userChoice)
    {
        case 1: BandReister();
            break;
        case 2: Console.WriteLine("\nList of all bands:");
            foreach (string band in bands)
            {
                Console.WriteLine($"- {band}");
            }
            Console.ReadKey();
            break;
        case 3: Console.WriteLine ("\nYou chose option " + choice);
            break;
        case 4: Console.WriteLine ("\nYou chose option " + choice);
            break;
        case -1: Console.WriteLine ("\nYou choose for exit, bye bye! ");
            break;
        default: Console.WriteLine ("\nInvalid option. Please try again.");
            break;
    }
}

void BandReister()
{
    Console.Clear();
    Console.WriteLine("You chose to register a new band.");
    Console.Write("Enter the name of the band: ");
    string bandName = Console.ReadLine()!;
    bands.Add(bandName);
    Console.WriteLine($"The band {bandName} has been registered.");
    Thread.Sleep(2000);
    Console.Clear();
    WelcomeMessage();
    Menu();

}

WelcomeMessage();
Menu();