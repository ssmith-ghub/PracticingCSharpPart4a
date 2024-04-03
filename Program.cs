using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gotchaDayOne = 5.5; //const prevents this "double" variable from being changed later on
            double gotchaDayTwo = 4.15;
            string dogNameOne = "Boomer";
            string dogNameTwo = "Ace";
            bool petLove = true;
            

            Console.WriteLine("We've had " + dogNameOne + " and " + dogNameTwo + " for a combined " + (gotchaDayOne + gotchaDayTwo) + " years!");
            Console.ReadKey();
            Console.Write("Do we love the dogss\b?\n\t" + petLove);
        }
    }
}
