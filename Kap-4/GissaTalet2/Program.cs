// Spelet - Gissa ett slupmtal 1-100
Console.Clear();
Console.WriteLine("Spelet - gissa ett slumptal 1-100");

// Slumpar ett tal 1-100
Console.WriteLine("Ange slumptalets min-värde");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ange slumptalets max-värde");
int max = int.Parse(Console.ReadLine()!);

int slumptal = Random.Shared.Next(min,max+1);

// Upprepning - loop
while (true)
{
    // Ställ fråga till spelaren
    Console.Write("Gissa ett tal (min-max): ");
    int gissning = int.Parse(Console.ReadLine()!);

     // kontroll om gissning är rätt?
     if (gissning == slumptal)
     {
        Console.WriteLine("Rätt gissat!");
     }
     else if (gissning > slumptal)
     {
        Console.WriteLine("För högt!");
     }
     else
     {
         Console.WriteLine("För lågt");
     }   

     // Vill spelaren gissa en gång till?
     Console.WriteLine("vill du gissa en gång till? (j/n): ");
     string svar = Console.ReadLine()!;
     if (svar == "n")
     {
     break;
     }
}

// Slut på spelet
Console.WriteLine("Slut, tack för att du spelade mitt spel!");