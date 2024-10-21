// Ett program för kryptering

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för Ceasar-chiffer!");

// alfabetet, lista av bokstäver att använda
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange ett meddelande
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine()!.ToUpper();

// Be användaren om en nyckel
Console.Write("Ange en nyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine()!);

// loopa igenom meddelandet bokstav efter bokstav
foreach (var bokstav in meddelande)
{
    // Hitta bokstavens position (index)
    int index = alfabetet.IndexOf(bokstav);
    //Console.WriteLine($"'A' så är index={index}");

    // Om bokstaven finns i alfabetet
    if (index != -1)
    {
        // Ceasar-kryptering, addera en nyckel(tex 2)
        int nyIndex = index + nyckel;
        //Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

        // börja om från början efter 28
        if (nyIndex >= alfabetet.Length)
        {
            nyIndex = nyIndex - alfabetet.Length;
        }

        // plocka ut bokstaven för nyIndex
        char krypteradBokstav = alfabetet[nyIndex];
        //Console.WriteLine($"{nyIndex} är bokstaven {krypteradBokstav}");
        Console.Write(krypteradBokstav);
    }
    else
    {
        //Console.WriteLine($"Bokstaven oförändrad: {bokstav}");
        Console.Write(bokstav);
    }
}