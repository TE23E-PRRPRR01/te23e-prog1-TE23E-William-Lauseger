// Programmet som frågar användaren hur många datorer hen äger. Skriptet ska sedan skriva ut korrekt i singular eller plural
Console.Clear();
Console.Write("Hej, hur många datorer har du? ");
string antal = Console.ReadLine()!;
if (antal== "1")
{
    Console.WriteLine("Du har 1 dator");
}
else
{
    Console.WriteLine($"Du har {antal} datorer");
}
