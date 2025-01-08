/* ****************************
* ********** M A I N **********
******************************* */

Console.Clear();
Console.WriteLine("Hej metoder!");

// Anropa/Använd metoden
SägHej();
SägHej();
/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>
static void SägHej()
{
    Console.Write("Hej på dig!");
}

/// <summary>
/// Metod för att visa en meny
/// </summary>

VisaMeny();
static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta
    """);
}



/* ****************************
* ******* M E T O D E R *******
******************************* */

// Anropa metoden RegistreraNamn()
RegistreraNamn();

/// <summary>
/// Metod för att ange namn
/// </summary>
static void RegistreraNamn()
{
    Console.WriteLine("Ange namn: ");
    string namn = Console.ReadLine()!;
    Console.WriteLine(namn);
}