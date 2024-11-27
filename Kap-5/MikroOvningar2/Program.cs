Console.Clear();

// Skapa en lista med 5 namn
List<string> listaNamn = ["Uzayon", "Oliver", "Alma", "Sandra", "Olga"];
Console.WriteLine($"Mina kompisar är: {string.Join(", ", listaNamn)}");

// Skapa en lista med 5 städer
List<string> listaStäder = ["Detroit", "Miami", "Dallas", "New York", "Los Angeles"];
Console.WriteLine($"5 städer {string.Join(", ", listaStäder)} som ligger i USA");

// Skapa en lista med 5 årtal
List<int> listaÅrtal = [1891, 1945, 2007, 2015, 2024];
Console.WriteLine($"5 viktiga årtal: '{string.Join("', '", listaÅrtal)}'");

// Lägg till och ta bort namn i listan
List<string> listaDryck = ["Coca Cola", "fanta", "Pomac", "7Up", "Bloody Mary"];
Console.WriteLine($"Nuvarande lista: {string.Join(", ", listaDryck)}");
Console.Write("Ange dryck att lägga till: ");
List<string> nyDryck = ["Coca cola", "fanta", "pomac", "7up", "bloody mary"];
