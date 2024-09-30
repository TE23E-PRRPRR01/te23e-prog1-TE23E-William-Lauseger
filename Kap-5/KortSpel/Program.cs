// Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpar ett kort ur en kortlek!");

// Skapa en lista kort

//List<string> kortlek = ["Ess", "Tvåa", "trea", "fyra", "femma", "sexa", "sjua", "åtta", "nia", "tia", "knekt", "dam", "kung"];
List<string> kortlek = ["🂡", "🂢", "🂣", "🂤", "🂥", "🂦",
"🂧", "🂨", "🂨", "🂪", "🂬", "🂭", "🂮"];

int antal = 5;
while (antal > 0)
{
    // Slumpa index 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    // Console.WriteLine($"Det slumpade index = {index}");

    // Plocka ut det 7:e kortet, index = 6
    string kort = kortlek[index];

    // Ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    // Skriv ut 7:e kortet
    Console.WriteLine($"Det slumpade kortet är {kort}");

    // Räkna ned
    antal--;
}