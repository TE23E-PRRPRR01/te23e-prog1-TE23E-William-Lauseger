// Skapa ett program som implementerar valfria åldersgränser
// Välj 4 åldersgränser och associera dem med något som är tillåtet att göra vid den åldern.
Console.Clear();
// Här kommer du få veta vad du får göra vid vissa åldrar
Console.WriteLine("Ange din ålder");
string ålderText = Console.ReadLine();
int ålder = int.Parse(ålderText);

if (ålder == 18 || ålder == 19 )
{
    Console.WriteLine("Du får köra bil, dricka alkohol och sommarjobba");
}
else if (ålder == 15 || ålder == 16)
{
    Console.WriteLine("Du får köra moped och ha sex");
}
else if (ålder == 21 || ålder == 46)
{
    Console.WriteLine("Du får köpa alkohol och köra lastbil");
}



