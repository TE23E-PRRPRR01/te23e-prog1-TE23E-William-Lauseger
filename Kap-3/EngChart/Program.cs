// Program som simulerar kända Engineering Flowchart
Console.Clear();
Console.WriteLine("Välkommen till ingenjörs flödeschema");

// Visa en ASCii art
Console.WriteLine($"""
 $"   *.      
              d$$$$$$$P"                  $    J
                  ^$.                     4r  "
                  d"b                    .db
                 P   $                  e" $
        ..ec.. ."     *.              zP   $.zec..
    .^        3*b.     *.           .P" .@"4F      "4
  ."         d"  ^b.    *c        .$"  d"   $         %
 /          P      $.    "c      d"   @     3r         3
4        .eE........$r===e$$$$eeP    J       *..        b
$       $$$$$       $   4$$$$$$$     F       d$$$.      4
$       $$$$$       $   4$$$$$$$     L       *$$$"      4
4         "      ""3P ===$$$$$$"     3                  P
 *                 $       "'"        b                J
  ".             .P                    %.             @
    %.         z*"                      ^%.        .r"
       "*==*""                             ^"*==*""   
""");

Console.Write("Does it move? (y/n) ");
string answer = Console.ReadLine();

// Kolla om svaret är ja eller nej
if (answer == "y")
{ // y
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("no problem! ");
    }
    else
    {
        Console.WriteLine("plz use ducktape! ");
    }
}
else
{ // n
    Console.Write("Should it? (y/n) ");
    answer = Console.ReadLine();
    if (answer == "n")
    {
        Console.WriteLine("no problem");
    }
    else
    {
        Console.WriteLine("plz use WD-40! ");
    }
}