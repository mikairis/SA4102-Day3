using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
        /*Start:
        double priceOfGadget = 500;
        double discountPrice = 0;

        Console.WriteLine("Welcome to ISS gadget shop!");
        Console.Write("Number of item to purchase: ");
        int numOfGadget = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        double totalPrice = priceOfGadget * numOfGadget;

        if (totalPrice <= 2000)
        {
            Console.WriteLine("Please pay $" + totalPrice);
        }
        else if (totalPrice > 2000 && totalPrice <= 3000)
        {
            discountPrice = totalPrice * 0.97;
            Console.WriteLine("Please pay $" + discountPrice);
        }
        else if (totalPrice > 3000 && totalPrice <= 6000)
        {
            discountPrice = totalPrice * 0.95;
            Console.WriteLine("Please pay $" + discountPrice);
        }
        else if (totalPrice > 6000)
        {
            discountPrice = totalPrice * 0.92;
            Console.WriteLine("Please pay $" + discountPrice);
        }
        Console.WriteLine();
        Console.WriteLine("To re-enter purchase details, press \"enter\".");
        Console.WriteLine();
        Console.ReadKey();
        goto Start;*/

        /*int count = 0;
        int[] testArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i < testArray.Length; i++)
        {
            //Console.WriteLine(testArray[i]);
            int numChecker = testArray[i];
            while (count <= numChecker)
            {
                Console.Write("*");
            }
            count++;
            Console.WriteLine();
        }

        //double testNum = Math.Sqrt(100);
        Console.WriteLine(Math.Sqrt(100));

        for (int i = testArray.Length - 1; i >= 0; i--)
        {
            int numChecker2 = testArray[i];
            while (numChecker2 <= count)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.ReadKey();*/

        /*Start:
        Console.Write("Please enter an integer: ");
        string input = Console.ReadLine();

        int value;

        bool isParsable = Int32.TryParse(input, out value);

        if (isParsable)
        {
            Console.WriteLine("The integer that you've entered is {0}", value);
        }
        else
        {
            //Console.WriteLine("You din't enter an integer");
            Console.WriteLine("You have not entered an integer.");
            goto Start;
        }
        Console.ReadKey();
        Console.WriteLine();
        goto Start;*/
        /*Start:
        int count = 0;
        Random randomNumberGenerator = new Random();
        do
        {
            int randomNumber = randomNumberGenerator.Next(0, 100);
            Console.WriteLine(randomNumber);
            count++;
        }
        while (count <= 10);
        Console.ReadKey();
        goto Start;*/

        Start:
            Random numGenerator = new Random();

            Console.WriteLine("This is a number guessing game. Guess a number between 0 to 10");
            Console.WriteLine("Enter an integer to guess number: ");

            int randomNum = numGenerator.Next(0, 11);
            int numGuess = Convert.ToInt32(Console.ReadLine());

            if (numGuess == randomNum || numGuess == 2)
            {
                Console.WriteLine("Congratulations! You guessed right!\nThe number is indeed " + numGuess);
                Console.ReadKey();
                Console.WriteLine();
                goto Start;
            }
            else
            {
                Console.WriteLine("Sorry! You guessed wrong!\nThe number is " + randomNum + "\nPlease try again!");
                Console.ReadKey();
                Console.WriteLine();
                goto Start;
            }
        }
    }
}
