// Program som tar fram användarens BMI
Console.Clear();
Console.WriteLine("Program som tar fram din BMI med hjälp av vikt i kg och längd i m");


Console.WriteLine("Ange din Vikt i Kg");
double vikt = double.Parse(Console.ReadLine()!);

Console.WriteLine("Ange din Längd i m");
double längd = double.Parse(Console.ReadLine()!);

double BMI = vikt / (längd * längd);

Console.WriteLine($"Din BMI är {BMI}");