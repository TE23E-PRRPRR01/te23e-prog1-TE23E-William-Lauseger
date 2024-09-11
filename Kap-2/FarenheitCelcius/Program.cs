// Program för att konvertera från Farenheit till celsius
Console.Clear();
Console.WriteLine("Program för att konvertera från Farenheit till Celsius");

// Läser in temperatur i Farenheit
Console.WriteLine("Ange temperaturen i Farenheit");
double tempFarenheit = double.Parse(Console.ReadLine());

// Konvertera Fa->Ce
double tempCelsius = (tempFarenheit - 32) * 5 / 9;

// Skriver ut resultaten
Console.WriteLine($"{tempFarenheit} F blir {tempCelsius} C");