Console.Clear();
Console.WriteLine("Samlingar");

// Skapa en lista med namn
List<string> listaNamn = ["William", "Oliver", "Alma"];

// Skriv ut listan med namn
string join = string.Join(", ", listaNamn);
Console.WriteLine(join);

// Låt användaren skriva in ett namn som ska läggas till
Console.Write("Ange ett namn att lägga in: ");
string nyttNamn = Console.ReadLine()!;

// Skriv in namnet i listan
listaNamn.Add(nyttNamn);
Console.WriteLine($"Alla namn efter tillägget: {string.Join(", ", listaNamn)}");

// Ange ett nytt namn att lägga till
Console.Write("Ange ett nytt namn att lägga till: ");
string nyttNamn2 = Console.ReadLine()!;

// Skriv ut det nya namnet i listan
listaNamn.Add(nyttNamn2);
Console.WriteLine($"Alla namn efter tillägget: {string.Join(", ", listaNamn)}");

