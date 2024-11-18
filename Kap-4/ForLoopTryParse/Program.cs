// Skapa en loop som körs 10 gånger
// Varje gång loopen körs ska den skriva ut ditt namn
Console.Clear();
//Variablar
int nummer = 1;

//Ange ditt namn
Console.Write("Ange ditt namn: ");
string namn = Console.ReadLine()!;


// Fråga hur många gånger användaren vill loopa
string loops = Console.ReadLine()!;
int antalloop = 0;
bool success = int.TryParse(loops, out antalloop);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{nummer++}. {namn}");
}
