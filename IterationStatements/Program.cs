using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below


        // LukeWarm Section:
        // Write a method that will print to the console all numbers 1000 through -1000
   // Write a method that will print to the console numbers 3 through 999 by 3 each time
//Write a method to accept two integers as parameterss and check whether they are equal or not
//Write a method to check whether a given number is even or odd
//Write a method to check whether a given number is positive or negative
//Write a method to read the age of a candidate and determine whether they can vote.
//Hint: Use Parse or the safer TryParse() for an extra challenge

//Parse()
//TryParse()

//Heatin Up Section:
//Write a method to check if an integer(from the user) is in the range -10 to 10
//Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        //methods are the method name, return type, modifier, parameters, scope

        static void Main(string[] args)
        {
            PrintRange();
            Threes();
            IsEqual(2, 2);
            EvenOrOdd(1);
            IsPositive(1);
            CheckAgeForVoting();

        }

        
        public static void PrintRange()          //Write a method that will print to the console all numbers 1000 through - 1000
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        public static void Threes()  //Write a method that will print to the console numbers 3 through 999 by 3 each time
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not

        public static bool IsEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void IsPositive(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else
            {
                Console.WriteLine($"{num} is negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote. parse - converting a string into the proper datatype
        public static void CheckAgeForVoting()
        {
            Console.WriteLine("What is your age?");
            bool canParse = int.TryParse(Console.ReadLine(), out int userInput);
            if( canParse == true)

            if(userInput < 18)
                {
                    Console.WriteLine("Sorry! You're too young to vote. Remind your friends over 18, to come and vote!");
                }
            else
                {
                    Console.WriteLine("You can vote!");
                }
        }


    }
}
