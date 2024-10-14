// Använda listor för att skapa/hantera samlingar av saker
Console.Clear();

// Skapa lista på trevliga frukter, t.ex. "äpple", "apelsin", "citron"
List<string> frukter = ["äpple", "apelsin", "citron"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Gå igenom listan = loopa igenom listan = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// skapa en lista på valfri sak (4st)
// Skriv ut varje sak på samma rad

List<string> pokemons = ["greninja", "lucario", "lycanroc", "gengar"];
foreach (var pokemon in pokemons)
{
    Console.WriteLine($"{pokemon}");
}

Console.Clear();
// Skapa ett register
// En tom lista
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine()!;
    namnlista.Add(namn);

    //Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}