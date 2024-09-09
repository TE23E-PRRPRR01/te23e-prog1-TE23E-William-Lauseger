// Att göra en interaktiv berättelse

Console.Clear();
Console.WriteLine("Du kommer fram till 2 dörrar. Vilken dörr väljer du? (1/2) ");
string answer = Console.ReadLine();

if (answer == "1")
{
    Console.WriteLine("Du blev dödad av en haj");
    answer = Console.ReadLine();

    if (answer == "2")
    {
        Console.WriteLine("Du vann 1 miljon dollar av Mr Beast men när du tog väskan med pengar så sköts du av en pil och dog");
    }
}
else
{
    
}


