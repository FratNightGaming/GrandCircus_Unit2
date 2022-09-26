using System;

namespace Radius
{
    class Program
    {
        public static bool input = true;

        static void Main(string[] args)
        {

            //InputRadius();
            SecondInputRadius();
        }

        public static void InputRadius()
        {
            Console.WriteLine("What is the radius of the circle?\n");

            float radius = float.Parse(Console.ReadLine());

            float area = MathF.PI * MathF.Pow(radius, 2);

            Console.WriteLine($"\nThe radius of the cirlce is: {area}\n");

            Console.WriteLine("Would you like to find the area of another circle? Enter 'y' or 'yes' to continue.\n");

            string answer = Console.ReadLine();

            while (answer == "y" || answer == "yes".ToLower())
            {
                Console.WriteLine();
                InputRadius();
            }

            Console.WriteLine("\nExit Program. Have a nice day.");

        }

        public static void SecondInputRadius()
        {
            while (input)
            {
                Console.WriteLine("What is the radius of the circle?\n");

                //float radius = float.Parse(Console.ReadLine());

                if (!float.TryParse(Console.ReadLine(), out float radius))
                {
                    Console.WriteLine("Enter a numerical value please.");
                    Console.WriteLine();
                    continue;
                }

                float area = MathF.PI * MathF.Pow(radius, 2);

                Console.WriteLine();
                Console.WriteLine($"The radius of the cirlce is: {area}");
                Console.WriteLine();

                Console.WriteLine("Would you like to find the area of another circle? Enter ''Y'' or ''Yes'' to continue.\n");

                string input = Console.ReadLine().ToUpper();

                if (input == "Y" || input == "YES")
                {
                    Console.WriteLine();
                    //SecondInputRadius();
                }

                else
                {
                    Console.WriteLine("\nExit Program. Have a nice day.");
                    break;
                }

            }
        }
    }
}
