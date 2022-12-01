// See https://aka.ms/new-console-template for more informa
using System.Collections.Generic;
using System.Security.Cryptography;
int points = 0;
string CN = "yes";
string C = CN.ToLower();
while (C == "yes")
{
    for (int D = 0; D < 21;)
    {
        var random = new Random();
        var card = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };
        points = random.Next(card.Count);
        D = D + points;
        if (D >= 21)
        {
            Console.WriteLine(D);
            Console.WriteLine("if your number is 21 you won big price...");
        }

    }
    Console.WriteLine("continue");
    C = Console.ReadLine();
}



