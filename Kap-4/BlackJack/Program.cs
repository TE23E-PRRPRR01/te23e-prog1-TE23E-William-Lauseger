// Spelet BlackJack även kallat 21
Console.Clear();
Console.WriteLine("Spelet BlackJack!");

// Kortens värde är
// 2-10 = 2-10
// Knekt, dam, kung = 10
// Ess = 1 (eller 11)
// @todo slump måste efterlikna riktig kortlek dvs 4x1, 4x2 ... 4xkung
// Variabler
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

// Dela ut 2 kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo knekt, dam & kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam & kung?
summaSpelare += kort;
// Dela ut 2 kort till datorn
kort = Random.Shared.Next(1, 11); // @todo knekt, dam & kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam & kung?
summaDator += kort;

// Flera gånger (loop)
while (true)
{
   // Skriv ut summorna
   Console.WriteLine($"Du har {summaSpelare} poäng");
   Console.WriteLine($"Datorn har {summaDator} poäng");

   // Stanna eller dra ett kort
   Console.WriteLine("Vill du ha ett nytt kort? (j/n)");
   string svar = Console.ReadLine()!.ToLower();
   if (svar == "n")
   {
       // @todo datorn får ta ett extra kort
       while (summaDator < 17)
       {
          kort = Random.Shared.Next(1, 11); // @todo knekt, dam & kung?
          summaDator += kort;
       }

       // Vem har vunnit
       // Den som är närmast 21 har vunnit
       if (summaSpelare > summaDator && summaSpelare < 21)
       {
           Console.WriteLine("Du har vunnit!");
       }
       else
       {
           Console.WriteLine("Datorn har vunnit");
       }
       break;
   }

   // Ta ett extra kort
   kort = Random.Shared.Next(1, 11); // @todo knekt, dam & kung?
   summaSpelare += kort;
   // Skriv ut kortet
   Console.WriteLine($"Du fick {kort}");

   // Datorn får också ett nytt kort
   kort = Random.Shared.Next(1, 11); // @todo knekt, dam & kung?
   summaDator += kort;
   // Skriv ut kortet
   Console.WriteLine($"Du fick {kort}");

   // Vem har vunnit?
   // Har datorn 21 har hen vunnit
   if (summaDator == 21)
   {
      Console.WriteLine("Datorn har vunnit");
      break;
   }
   // Har spelaren fått 21 har den vunnit
   if (summaSpelare == 21)
   {
      Console.WriteLine("Du har vunnit"); 
      break;
   }
   // är spelaren tjock?
   if (summaSpelare > 21)
   {
      Console.WriteLine("Du har förlorat");
      break;
   }
   // är datorn tjock?
   if (summaDator > 21)
   {
      Console.WriteLine("Du har vunnit"); 
      break;
   }
}