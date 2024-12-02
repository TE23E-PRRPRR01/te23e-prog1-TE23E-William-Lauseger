Console.Clear();

// // Exempel på maträtter
// List<string> listaMaträtt = ["Sushi", "Hamburgare", "Pizza"];
// Console.WriteLine("Alla maträtter: ");
// foreach (string maträtt in listaMaträtt)
// {
//     Console.WriteLine($"- {maträtt}");
// }

// // Skriv ut årtal i en lista
// List<int> listaÅrtal = [1891, 1945, 2007, 2015, 2025];
// Console.WriteLine("Alla årtal i listan: ");
// foreach (var årtal in listaÅrtal)
// {
//     Console.WriteLine($"- {årtal}");
// }

// // Skriv ut det på en rad
// List<int> listaÅr = [1891, 1945, 2007, 2015, 2025];
// Console.Write("Alla årtal: ");
// foreach (var år in listaÅr)
// {
//     Console.Write($"{år}, ");
// }

// Lägg till ett namn i lista
List<string> listaNamn = [];
while (true)
{
Console.Write("Ange ett namn att lägga till (eller 'exit' för att avsluta): ");
string namn = Console.ReadLine()!;
if (namn == "avsluta")
{
    break;
}
listaNamn.Add(Console.ReadLine()!);
}

