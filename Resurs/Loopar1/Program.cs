// using System.Runtime;

// Console.Clear();
// // Console.Write("Ange ditt namn: ");
// // string namn = Console.ReadLine()!;

// // Console.Write("Ange gatunamn: ");
// // string gatunamn = Console.ReadLine()!;

// // Console.Write("Ange hemstad: ");
// // string hemstad = Console.ReadLine()!;

// // Console.WriteLine($"Hej {namn}! Du bor på {gatunamn} i {hemstad}");

// // Console.Write("Ange ett lösenord: ");
// // string lösenord = Console.ReadLine()!;

// // if (lösenord == "hej")
// // {
// //     for (int i = 0; i < 5; i++)
// //     {
// //     Console.WriteLine("Välkommen in");
// //     }
// // }
// // else
// // {
// //     for (int i = 0; i < 10; i++)
// //     {
// //     Console.WriteLine("Fel lösenord");
// //     }
// // }

// Console.Write("Ange ditt namn: ");
// string namn = Console.ReadLine()!;

// // for (int i = 0; i < 5; i++)
// // {
// //     Console.Write("Ange lösenord: ");
// //string lösenord = Console.ReadLine()!;
// //     if (lösenord == "hej")
// //     {
// //         break;
// //     }
// //     else
// //     {
// //         Console.WriteLine("fel lösenord");
// //     }
// // }

// // while (true)
// // {
// //     Console.Write("Ange ett lösenord: ");
// //     string lösenord = Console.ReadLine()!;
// //     if (lösenord == "hej")
// //     {
// //         break;
// //     }
// // }

// // Console.WriteLine("välkommen");

// // for (int i = 0; i < 10; i++)
// // {
// //     Console.WriteLine("välkommen");
// // }

// // Console.Write("Ange din ålder: ");
// // int ålder = int.Parse(Console.ReadLine()!);
// // int nyålder = ålder + 6;

// // Console.WriteLine($"Hej {namn}! Du är {ålder} år. År 2030 är du {nyålder} år gammal");

// // Console.Write("Ange din födelsemånad (jan,feb,mar...): ");
// // string födelsemånad = Console.ReadLine()!;

// // if (födelsemånad == "jan")
// // {
// //     Console.WriteLine("Du är född i Januari");
// // }
// // else if (födelsemånad == "feb")
// // {
// //     Console.WriteLine("Du är född i Februari");
// // }
// // else if (födelsemånad == "feb")
// // {
// //     Console.WriteLine("Du är född i Februari");
// // }
// // else if (födelsemånad == "mar")
// // {
// //     Console.WriteLine("Du är född i Mars");
// // }
// // else if (födelsemånad == "apr")
// // {
// //     Console.WriteLine("Du är född i April");
// // }
// // else if (födelsemånad == "maj")
// // {
// //     Console.WriteLine("Du är född i Maj");
// // }
// // else if (födelsemånad == "jun")
// // {
// //     Console.WriteLine("Du är född i Juni");
// // }
// // else if (födelsemånad == "jul")
// // {
// //     Console.WriteLine("Du är född i Juli");
// // }
// // else if (födelsemånad == "aug")
// // {
// //     Console.WriteLine("Du är född i Augusti");
// // }
// // else if (födelsemånad == "sep")
// // {
// //     Console.WriteLine("Du är född i September");
// // }
// // else if (födelsemånad == "okt")
// // {
// //     Console.WriteLine("Du är född i Oktober");
// // }
// // else if (födelsemånad == "nov")
// // {
// //     Console.WriteLine("Du är född i November");
// // }
// // else if (födelsemånad == "dec")
// // {
// //     Console.WriteLine("Du är född i December");

// // Console.Write("Ange födelsemånad (1-12): ");
// // int födelsemånadTal = int.Parse(Console.ReadLine()!);
// // string månad = "";
// // if (födelsemånadTal == 1)
// // {
// //     Console.WriteLine("Du är född i Januari");
// //     månad = "Januari";
// // }
// // else if (födelsemånadTal == 2)
// // {
// //     Console.WriteLine("Du är född i Februari");
// //     månad = "Februari";
// // }
// // else if (födelsemånadTal == 3)
// // {
// //     Console.WriteLine("Du är född i Mars");
// //     månad = "mars";
// // }
// // else if (födelsemånadTal == 4)
// // {
// //     Console.WriteLine("Du är född i April");
// //     månad = "April";
// // }
// // else if (födelsemånadTal == 5)
// // {
// //     Console.WriteLine("Du är född i Maj");
// //     månad = "Maj";
// // }
// // else if (födelsemånadTal == 6)
// // {
// //     Console.WriteLine("Du är född i Juni");
// //     månad = "Juni";
// // }
// // else if (födelsemånadTal == 7)
// // {
// //     Console.WriteLine("Du är född i Juli");
// //     månad = "Juli";
// // }
// // else if (födelsemånadTal == 8)
// // {
// //     Console.WriteLine("Du är född i Augusti");
// //     månad = "Augusti";
// // }
// // else if (födelsemånadTal == 9)
// // {
// //     Console.WriteLine("Du är född i September");
// //     månad = "September";
// // }
// // else if (födelsemånadTal == 10)
// // {
// //     Console.WriteLine("Du är född i Oktober");
// //     månad = "Oktober";
// // }
// // else if (födelsemånadTal == 11)
// // {
// //     Console.WriteLine("Du är född i November");
// //     månad = "november";
// // }
// // else if (födelsemånadTal == 12)
// // {
// //     Console.WriteLine("Du är född i December");
// //     månad = "December";
// // }

// // Console.Write("Hur många gånger vill du loopa? ");
// // int antal = int.Parse(Console.ReadLine()!);

// // Console.WriteLine($"Du vill loopa {antal} loopar.");

// // for (int i = 0; i < antal; i++)
// // {
// // Console.WriteLine($"Din månad är {månad}");
// // }
Console.Clear();

Console.Write("Ange tal 1: ");
int tal1 = int.Parse(Console.ReadLine()!);

Console.Write("Ange tal2: ");
int tal2 = int.Parse(Console.ReadLine()!);

int summa = tal1 + tal2;
Console.WriteLine($"Summan av {tal1} och {tal2} = {summa}");

int produkt = tal1 * tal2;

Console.WriteLine($"Produkten av {tal1} och {tal2} = {produkt}");
int kvot = tal1 / tal2;

Console.WriteLine($"Kvot av {tal1} och {tal2} = {kvot}");
int differens = tal1 - tal2;

Console.WriteLine($"Differensen av {tal1} och {tal2} = {differens}");