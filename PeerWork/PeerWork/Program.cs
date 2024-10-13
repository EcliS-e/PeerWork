// See https://aka.ms/new-console-template for more informaI
using System;

/*Mariana Espinal 10/13/24
*IGME.201.01 - Interac Des & Alg Prob Sol III
*/
namespace program {
    class Program {
        static void Main(string[] args)
        {
            int marianaFavoriteNumber = 5;
            int maxFavoriteNumber = 4;

            //initialize
            marianaFavoriteNumber = 5;
            maxFavoriteNumber = 4;

            //start program
            Console.WriteLine("Mariana's favroite number is " + marianaFavoriteNumber);
            Console.WriteLine("Max's favorite number is " + maxFavoriteNumber);

            int Subtracting(int num1, int num2) {
                int result = num2 - num1;
                return result;
            }

            //store and display
           int addition =  Add(marianaFavoriteNumber, maxFavoriteNumber);
            Console.WriteLine(addition);
            int subtraction = Subtracting(marianaFavoriteNumber, maxFavoriteNumber);
                Console.WriteLine(subtraction);
        }

        /// <summary>
        /// Adds two numbers together and returns result
        /// </summary>
        /// <param name="num1">number </param>
        /// <param name="num2"> number </param>
        /// <returns> result</returns>
        static int Add(int num1, int num2)

        {
            int result = num1 + num2;
            return result;

        }
            }

}
       





