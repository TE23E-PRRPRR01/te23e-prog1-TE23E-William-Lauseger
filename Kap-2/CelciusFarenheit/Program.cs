// Program för att konvertera temperaturen Celsius till Farenheit
Console.Clear();
Console.WriteLine("Program för att konvertera Celsius till Farenheit");

// Läser in Temp i Celsius
Console.Write("Ange temperatur i Celsius ");
int tempCelsius = int.Parse(Console.ReadLine()!);

// Konvertera till Farenheit
int tempFarenheit = tempCelsius * 9 / 5 + 32;

// Skriver ut resultatet
Console.WriteLine($"{tempCelsius} Celsius är {tempFarenheit} Farenheit");