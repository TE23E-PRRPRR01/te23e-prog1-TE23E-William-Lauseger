/* ****************************
* ******** M A I N ************
******************************* */

Console.Clear();
Console.WriteLine("Hello, World!");

SägHejNamn("William");
SägHejNamn("Oliver");
SägHejNamn("Jemila");
SägHejNamn("");
KvadreraTal();

/* ****************************
* ******* M E T O D E R *******
******************************* */

/// <summary>
/// Skriv ut hälsning
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}


/// <summary>
/// Metod som skriver ett tal i kvadrat
/// <summary>
/// <param name="Tal"></param>
static void KvadreraTal(int Tal)
{
    Console.WriteLine($"tal i kvadrat = {Tal * Tal}");
}