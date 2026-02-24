using System;

enum Numbers
{
    One = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten
}

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Generate random number from 1 to 10
        int randomNumber = rand.Next(1, 11);

        // Convert int to enum
        Numbers result = (Numbers)randomNumber;

        Console.WriteLine("Random Number: " + randomNumber);
        Console.WriteLine("Enum Value: " + result);

        // Using switch with enum
        switch (result)
        {
            case Numbers.One:
                Console.WriteLine("You got One!");
                break;

            case Numbers.Two:
                Console.WriteLine("You got Two!");
                break;

            case Numbers.Three:
                Console.WriteLine("You got Three!");
                break;

            case Numbers.Four:
                Console.WriteLine("You got Four!");
                break;

            case Numbers.Five:
                Console.WriteLine("You got Five!");
                break;

            case Numbers.Six:
                Console.WriteLine("You got Six!");
                break;

            case Numbers.Seven:
                Console.WriteLine("You got Seven!");
                break;

            case Numbers.Eight:
                Console.WriteLine("You got Eight!");
                break;

            case Numbers.Nine:
                Console.WriteLine("You got Nine");
                break;

            case Numbers.Ten:
                Console.WriteLine("You got Ten");
                break;

            default:
                Console.WriteLine("You got something else!");
                break;
        }
    }
}