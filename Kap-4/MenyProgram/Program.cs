// Litet program med meny
Console.Clear();
Console.WriteLine("litet program med meny");

// variabel för valet
string val = "";

// Programloop som snurrar tills användaren säger avsluta
while (true)
{
    // Visar en meny och läser användarens val
    Console.Write("""
    1. omvandla en text till versaler
    2. omvandla en text till gemener
    3. avsluta
    Välj ett av alternativen ovan:
    """);
    val = Console.ReadLine()!;

    // Hantera användarens val
    if (val== "1")
    {
        Console.Write("Skriv in en text");
        string texten = Console.ReadLine()!.ToUpper();
        Console.WriteLine($"Texten i versaler blir:{texten}");
    }
    else if (val== "2")
    {
        Console.Write("Skriv in en text");
        string texten = Console.ReadLine()!.ToLower();
        Console.WriteLine($"Texten i versaler blir:{texten}");
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