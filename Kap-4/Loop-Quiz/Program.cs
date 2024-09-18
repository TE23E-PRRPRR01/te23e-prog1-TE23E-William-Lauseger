// Quiz om NFL
using System.Formats.Asn1;

Console.Clear();
Console.WriteLine("Välkommen till Quiz om NFL");

Console.WriteLine("Vad är ditt namn?");
string namn = Console.ReadLine()!;

while (true)
{
    Console.Write("Fråga 1: Vilket lag vann Super Bowl senast? (Chiefs/Eagles/49ers)");
    string lag = Console.ReadLine()!.ToLower();

    if (lag == "chiefs")
    {
        Console.WriteLine("Korrekt");
    }
    else
    {
        Console.WriteLine("Inkorrekt");
    }


    Console.WriteLine("Fråga 2: Hur många gånger vann Patriots Super Bowl? (4/9/6)");
    string gånger = Console.ReadLine()!;

    if (gånger == "6")
    {
        Console.WriteLine("Korrekt");
    }
    else
    {
        Console.WriteLine("Inkorrekt");
    }

    Console.WriteLine("Fråga 3: Vilket efternamn har den bästa Quarterbacken genom alla tider? (Brady/Montana/Mahomes)");
    string efternamn = Console.ReadLine()!.ToLower();

    if (efternamn== "brady")
    {
        Console.WriteLine("Korrekt");
    }
    else
    {
        Console.WriteLine("Inkorrekt");
    }
    
    Console.WriteLine("Fråga 4: Hur många poäng ger en Touchdown? (7/6/9)");
    string poäng = Console.ReadLine()!;

    if (poäng== "6")
    {
        Console.WriteLine("Korrekt");
    }
    else
    {
        Console.WriteLine("Inkorrekt");
    }

    Console.WriteLine($"{namn}, vill du köra igen? (y/n)");
    string answer = Console.ReadLine()!;
     if (answer== "n")
    {
        break;
    }
}

Console.WriteLine("Tack för att du har spelat mitt Quiz om NFL");
