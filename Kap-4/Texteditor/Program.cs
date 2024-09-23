// Program som läser från fil och skriver till fil
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Program som läser från fil och skriver till fil");

// Variabel för valet
string val = "";

// Programloop som håller på tills användaren vill avsluta
while (true)
{
    // Visar meny och läser användarens val
    Console.Write("""
    1. Skriv till fil
    2. Läs till fil
    3. Avsluta
    Välj ett av alternativen ovan :
    """);
    val = Console.ReadLine()!;

    // Hantera användarens val
    if (val== "1")
    {
        // Skriv in text till fil
        Console.Write("Skriv text till filen");
        string texten = Console.ReadLine()!;
        File.WriteAllText("filenamn.txt", texten);
    }
    else if (val== "2")
    {
        if (File.Exists("filnamn.txt"))
        {
            string texten = File.ReadAllText("filnamn.txt");
        }
        else
        {
            Console.WriteLine("Filen finns inte!");
        }
    }
    else if (val== "3")
    {
        Console.WriteLine("avslutar...");
        break;
    }
    else
    {
        Console.WriteLine("Du valde inget giltigt alternativ, Försök igen");
    }
}
