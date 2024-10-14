// Skapa ett program som frågar användaren efter en månad och skriver ut antalet dagar i den månaden.
Console.Clear();
while (true)
{
    Console.Write("Hej, ange en månad: ");
    string månad = Console.ReadLine()!.ToLower();
    if (månad == "januari")
    {
        Console.WriteLine("Januari har 31 dagar");
    }
    else if (månad == "februari")
    {
        Console.WriteLine("Februari har 28 dagar");
    }
    else if (månad == "april")
    {
        Console.WriteLine("April har 30 dagar");
    }
}