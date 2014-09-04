using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        //Declared all the variables outside of main, so that they are visible in the GuessThatNumber method also
        public static int guesses = 0;
        public static Random rng = new Random();
        public static int compNum = rng.Next(1, 101);
        //flag to indicate when to exit the loop
        public static bool flag = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number: ");
            GuessThatNumber(int.Parse(Console.ReadLine()));
        }

        static void GuessThatNumber(int userNum)
        {

            while (flag == false)
            {
                guesses++;
                if (userNum == compNum)
                {
                    Console.WriteLine("Congratulations! You guessed correctly");   
                    Console.WriteLine("It took you " +guesses+ " guesses");             
                    flag = true;
                }
                else if (userNum > compNum)
                {
                    Console.WriteLine("Your guess is too high. Try again");
                    GuessThatNumber(int.Parse(Console.ReadLine()));
                 }
                else
                {
                    Console.WriteLine("Your guess is too low. Try again");
                    GuessThatNumber(int.Parse(Console.ReadLine()));
                }
            }
        }
    }
}
