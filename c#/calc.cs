using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Velkommen til det enkle kalkulatorprogrammet!");

        // Input to heltall fra brukeren
        Console.Write("Skriv inn det første heltallet: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Skriv inn det andre heltallet: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Meny for brukeren
        Console.WriteLine("\nVelg en av følgende operasjoner:");
        Console.WriteLine("1. Addisjon");
        Console.WriteLine("2. Subtraksjon");
        Console.WriteLine("3. Multiplikasjon");
        Console.WriteLine("4. Divisjon");

        Console.Write("Skriv inn valget ditt (1/2/3/4): ");
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case '1':
                Console.WriteLine("Resultatet av addisjonen er: " + (num1 + num2));
                break;
            case '2':
                Console.WriteLine("Resultatet av subtraksjonen er: " + (num1 - num2));
                break;
            case '3':
                Console.WriteLine("Resultatet av multiplikasjonen er: " + (num1 * num2));
                break;
            case '4':
                if (num2 != 0)
                {
                    Console.WriteLine("Resultatet av divisjonen er: " + ((double)num1 / num2));
                }
                else
                {
                    Console.WriteLine("Kan ikke dele på null!");
                }
                break;
            default:
                Console.WriteLine("Ugyldig valg");
                break;
        }
    }
}
