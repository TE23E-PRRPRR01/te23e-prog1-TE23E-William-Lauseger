Console.Clear();

// Skapa en to lista för pizzarätter
List<string> pizzas = [];

// Skapa en to lista för frukter
List<string> frukter = [];

// Skapa en to lista för skostorlekar
List<int> skostorlekar = [];

// Skapa en lista med tre förnamn
List<string> namnlista = ["Axel", "Oliver", "Alma"];

// Lägg till i listor med .add()
// Lägg till tre pizzor
pizzas.Add("Vesuvio");
pizzas.Add("Blanco");
pizzas.Add("Vegetariana");

// Lägg till tre frukter
frukter.Add("Banan");
frukter.Add("Apelsin");
frukter.Add("Jordgubb");

// Skriv ut alla frukter
foreach (var frukt in frukter)
{
    Console.WriteLine($"- {frukt}");
}

// Skriv ut alla pizzor
foreach (var pizza in pizzas)
{
    Console.WriteLine($"- {pizza}");
}

// Låt användaren mata in en 4:e pizza
Console.Write("Ange en ny pizza: ");
string nypizza = Console.ReadLine()!;
pizzas.Add(nypizza);


// Låt användaren mata in ett 4:e namn
Console.Write("Vad heter du? ");
string nynamn = Console.ReadLine()!;
namnlista.Add(nynamn);

// Skriv ut alla namn
foreach (var namn in namnlista)
{
    Console.WriteLine($"- {namn}");
}

// Nu låter vi användaren mata in skostorlekar
Console.Write("Ange din skostorlek: ");
int input = int.Parse(Console.ReadLine()!);
skostorlekar.Add(input);

// Skriv skostorlekar
foreach (var skostorlek in skostorlekar)
{
    Console.WriteLine($"- {skostorlek}");
}

// Hur många pizzor har vi?
int antal = pizzas.Count;
Console.WriteLine($"Totalt antal pizzor = {antal}");

// Hur många frukter?
Console.WriteLine($"Totalt antal frukter = {frukter.Count}");

// Hur många namn har vi i listan?
Console.WriteLine($"Totalt antal namn = {namnlista.Count}");

// Skriv ut första namnet
Console.WriteLine($"Första namnet är {namnlista[0]}");

// Skriv ut andra namnet
Console.WriteLine($"Andra namnet är {namnlista[1]}");

// Skriv ut sista namnet
Console.WriteLine($"Sista namnet är {namnlista[3]}");

// Byta ut första namnet med annat namn
namnlista[0] = "William";

// Skriv ut första namnet
Console.WriteLine($"Första namnet är {namnlista[0]}");

// Byt ut andra namnet med ???
namnlista[1] = "Olaf";
Console.WriteLine($"Andra namnet är {namnlista[1]}");

// Be användaren byta ut första pizzan
Console.Write("Ange ny första pizza: ");
string nyförstapizza = Console.ReadLine()!;
pizzas[0] = nyförstapizza;

// Be användaren vilken pizza som ska bytas ut 
Console.Write("Vilken pizza vill du byta ut (0, 1, 2)? ");
int index = int.Parse(Console.ReadLine()!);

// Be användaren ange den nya pizzan
Console.Write("Vad heter nya pizzan? ");
nypizza = Console.ReadLine()!;
pizzas[index] = nypizza;