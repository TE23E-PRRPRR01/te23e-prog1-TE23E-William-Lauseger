// Slumpa 2 av 10 städer
Console.Clear();
Console.WriteLine("Slumpa 2 av 10 stader!");

// Skapa en lista städer
List<string> stader = ["Seol", "Tokyo", "Paris", "Madrid", "London", "Miami",
"New York", "Stockholm", "Biograd", "New Delhi", "Los Angeles"];

int antal = 2;
while (antal > 0)
{
    // Slumpa index 0-12
    int index = Random.Shared.Next(0, 11);
    // Console.WriteLine($"Det slumpade index = {index}");

    // Plocka ut det 7:e staden, index = 6
    string stad = stader[index];

    // Skriv ut 7:e staden
    Console.WriteLine($"Den slumpade staden är {stad}");

    // Räkna ned
    antal--;
}
