Console.Clear();
Console.WriteLine("Film register");

// Skapa en lista med actionspel
List<string> listaAction = [];

// Skapa en lista med äventyrsspel
List<string> listaAdventure = [];

// Skapa en fråga för att lägga till fler spel
Console.WriteLine("Nu ska du lägga till 2 actionspel i listan: ");
Console.Write("Ange 1 actionspel att lägga till: ");
string spel = Console.ReadLine()!;
listaAction.Add(spel);
Console.Write("Ange 1 actionspel att lägga till: ");
spel = Console.ReadLine()!;
listaAction.Add(spel);

// Fyll på listan med äventyrsspel med hjälp av for-loop
Console.WriteLine("Du ska nu fylla i 3 äventyrsspel: ");
for (int i = 0; i < 3; i++)
{
    Console.Write("Ange 1 äventyrsspel att lägga till: ");
    spel = Console.ReadLine()!;
    listaAction.Add(spel);
}

Console.WriteLine("Du ska nu fylla i 2 actionspel: ");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange 1 actionspel att lägga till: ");
    spel = Console.ReadLine()!;
    listaAction.Add(spel);
}
