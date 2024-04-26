using System;
using System.Net.Security;


public class CoinFlip
{
    public static void Main()
    {
        Random rnd = new Random();
        int i = 0;
        int score = 0;
        int total_score;


        //Name
        Console.WriteLine("What's you name?");
        string name =Console.ReadLine();

        //Coin Flip
       
        Console.WriteLine("Hello, "+name + ". Do you want to try a coin flip game? Type 'Y' for yes and 'N' for no.");
        string Answer = Console.ReadLine();
        if (Answer == "N") { Console.WriteLine("You got to be kidding. Are you chicken?"); }
        else

            while (i < 5)
            {

                {

                    Console.WriteLine(name +" ,for heads type 'H'. For tails type T.");
                    string Guess = Console.ReadLine();
                    int Flip = rnd.Next(0, 2);
                    string Flipstring = Flip.ToString();
                    if (Flipstring == "0" && Guess == "H" || Flipstring == "1" && Guess == "T") { score = score +1; }
                       else {score = score + 0;}
                    Console.WriteLine(Flipstring);
                  
                }
                int total = score;
                             
                i++;

                //Total Score 

                if (i == 5)
                { Console.WriteLine("Thank you, " + name + ". You have a score of:" + total + "."); } 
            }
    }
    
}