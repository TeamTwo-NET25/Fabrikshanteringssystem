using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
class Program
{
    static List<string> inventory = new List<string>();
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");
        while (true)
        {
            Console.WriteLine("\nVälj en åtgärd:");
            Console.WriteLine("1. Lägg till produkt");
            Console.WriteLine("2. Ta bort produkt");
            Console.WriteLine("3. Visa inventarier");
            Console.WriteLine("5. Sök produkt");
            Console.WriteLine("4. Avsluta");
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
                    TaBortProdukt();
                    break;
                case "4":
                    return;
                case "5":
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
    static void LäggTillProdukt()
    {
        Console.Write("Ange produkt att lägga till: ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) 
        {
            Console.WriteLine("Du måste ange produkt!");
            Console.ReadKey(true);
            return;
        }
        inventory.Add(input.Substring(0).ToUpper().Substring(1));
        
    }
    static void VisaInventarie()
    {
        // TODO: Implementera metod för att visa inventarie
    }
    static void TaBortProdukt()
    {
        Console.Write("Ange produkt att ta bort: ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Du måste ange produkt!");
            Console.ReadKey(true);
            return;
        }
        
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].Contains(input, StringComparison.CurrentCultureIgnoreCase))
            {
                inventory.RemoveAt(i);
                break;
            }
        }
        Console.WriteLine("Produkt raderad!");
        Console.ReadKey(true);

    }
}