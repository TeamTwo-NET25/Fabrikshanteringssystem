using System;
using System.Collections.Generic;
class Program
{
    static List<string> inventory = new List<string>();
    static void Main(string[] args)
    {
        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");
        while (true)
        {
            Console.WriteLine("\nVälj en åtgärd:");
            Console.WriteLine("1. Lägg till produkt");
            Console.WriteLine("2. Visa inventarie");
            Console.WriteLine("3. Avsluta");
            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    LäggTillProdukt();
                    break;
                case "2":
                    VisaInventarie();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
    static void LäggTillProdukt()
    {
        // TODO: Implementera metod för att lägga till produkt
    }
    static void VisaInventarie(List<string> products = null!)
    {
        // TODO: Implementera metod för att visa inventarie
    }

    static IEnumerable<string> SökProdukt()
    {
        string search = "";
        while (true)
        {
            Console.Write("Ange sökkriterier: ");
            search = Console.ReadLine()!;
            if (!string.IsNullOrWhiteSpace(search))
            {
                break;
            }
        }
        List<string> results = inventory.FindAll(p => p.Contains(search));
        VisaInventarie(results);
    }
}