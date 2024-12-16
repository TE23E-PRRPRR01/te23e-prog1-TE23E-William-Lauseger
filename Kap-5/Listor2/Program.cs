Console.Clear();
Console.WriteLine("Allt om listor");

// Skapa en tom lista
List<string> listaNamn = [];

// Infoga i en lista
listaNamn.Add("William");
listaNamn.Add("Oliver");
listaNamn.Add("Alma");
Console.WriteLine(listaNamn.Count);

// Skriv ut listan
Console.WriteLine($"Lista: {listaNamn}");

// Skriv ut listan med hjälp av en loop
foreach (var namn in listaNamn)
{
    Console.WriteLine($"- {namn}");
}

// Skriv ut första elementet i listan (index = 0)
Console.WriteLine($"Första elementet: {listaNamn[0]}");

// Skriv ut två namn ut listan
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"{i}: {listaNamn[1]}");
}

// Skriv ut alla namn i listan med for-loop
for (int i = 0; i < listaNamn.Count; i++)
{
    
}