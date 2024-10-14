// användaren ska mata in ett tal, sedan en operation
// och slutligen ett tal. Efter det ska resultatet skrivas ut
Console.Clear();
Console.WriteLine("Kalkylator");
while (true)
{
    Console.Write("ange tal 1: ");
    int tal1 = int.Parse(Console.ReadLine());
    Console.Write("Ange en operation: (+/-/*/a) ");
    string operation = Console.ReadLine();
    Console.Write("Ange tal 2: ");
    int tal2 = int.Parse(Console.ReadLine());
    if (operation == "+")
    {
        int summa = tal1 + tal2;
        Console.Write($"{tal1} + {tal2} = {summa}");
    }
    else if (operation == "-")
    {
        int skillnad = tal1 - tal2;
        Console.Write($"{tal1} - {tal2} = {skillnad}");
    }
    else if (operation == "*")
    {
        int produkt = tal1 * tal2;
        Console.Write($"{tal1} * {tal2} = {produkt}");
    }
    else if (operation== "a")
    {
        Console.WriteLine("Tack för att du använde kalkylatorn");
        break;
    }
    else
    {
        Console.WriteLine("Du har inte valt något");
    }
    Console.WriteLine();
}
