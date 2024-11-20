Console.Clear();
// Console.Write("Ange startvärde: ");
// int startvärde = int.Parse(Console.ReadLine()!);

// Console.Write("Ange slutvärde: ");
// int slutvärde = int.Parse(Console.ReadLine()!);
// int summa = 0;
// for (int i = startvärde; i < slutvärde + 1; i++)
// {
//     Console.WriteLine(i);
//     summa += i;
// }
// Console.WriteLine($" Summan av alla heltal är {summa}");

// Console.Write("Ange startvärde2: ");
// int startvärde2 = int.Parse(Console.ReadLine()!);

// Console.Write("Ange slutvärde2: ");
// int slutvärde2 = int.Parse(Console.ReadLine()!);
Console.Write("Jämna siffror: ");
for (int i = 0; i < 21; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
}
Console.WriteLine();

Console.Write("Udda siffror: ");
for (int i = 0; i < 21; i++)
{
    if (i % 2 != 0)
    {
        Console.Write($"{i}, ");
    }
}