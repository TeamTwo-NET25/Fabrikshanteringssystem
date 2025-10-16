using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
class Program
{
    static List<string> inventory = new List<string>();
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");
            Console.WriteLine("\nVälj en åtgärd:");
            Console.WriteLine("1. Lägg till produkt");
            Console.WriteLine("2. Ta bort produkt");
            Console.WriteLine("3. Visa inventarier");
            Console.WriteLine("4. Sök produkt");
            Console.WriteLine("5. Avsluta");
            string val = Console.ReadLine();
            switch (val)
            {
                case "1":
                    LäggTillProdukt();
                    break;
                case "2":
                    TaBortProdukt();
                    break;
                case "3":
                    VisaInventarie();
                    break;
                case "4":
                    SökProdukt();
                    break; 
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
        inventory.Add(input);
        Console.WriteLine("Produkten tillagd!");
        Console.ReadKey(true);

    }
    static void VisaInventarie(List<string> products = null!)
    {
        if (products == null)
        {
            products = inventory;
        }
        if (products == null)
        {
            Console.WriteLine("Inventariet är tomt.");
        }
        else
        {
            Console.WriteLine("\nInventarielista:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}");
            }
        }
        Console.ReadKey(true);
    }

    static void SökProdukt()
    {
        string search = "";
        while (true)
        {
            Console.Write("Ange sökkriterier: ");
            search = Console.ReadLine().ToLower()!;
            if (!string.IsNullOrWhiteSpace(search))
            {
                break;
            }
        }
        List<string> results = inventory.FindAll(p => p.ToLower().Contains(search));
        VisaInventarie(results);
        
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

    static void Tjena()
    {
        // HEj
    }
}