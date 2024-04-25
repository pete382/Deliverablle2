using System;


public class CoinFlip
{
    public static void Main()
    {
        Random rnd = new Random();
        int i = 0;
        int score = 0;
        int total_score;

        Console.WriteLine("Do you want to try a coin flip game? Type 'Y' for yes and 'N' for no.");
        string Answer = Console.ReadLine();
        if (Answer == "N") { Console.WriteLine("You got to be kidding. Are you chicken?"); }
        else

            while (i < 5)
            {

                {

                    Console.WriteLine("For heads type 'H'. For tails type T.");
                    string Guess = Console.ReadLine();
                    int Flip = rnd.Next(0, 1);
                    string Flipstring = Flip.ToString();

                    if (Flipstring == "0" && Guess == "H") { Console.WriteLine(total_score = score + 1); }
                    else if (Flipstring == "1" && Guess == "T") { Console.WriteLine(total_score = score + 1); }
                    else { Console.WriteLine("0"); }
                    Console.WriteLine(Flipstring);
                    Console.WriteLine(Guess);
                    Console.WriteLine(score);
                }
                i++;
                
            }
    }
} //| Flipstring == "1" && Guess == "T"