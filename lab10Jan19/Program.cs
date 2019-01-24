using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10Jan19
{
    class Program
    {
        public static double radius { get; private set; }
        static void Main(string[] args)
        {
            int amountOfCircles = 0;
            bool runP = true;
            while (runP == true)
            {            
                try
                {
                    Console.WriteLine("\nPlease enter the radius of a circle");
                    string input = Console.ReadLine();
                    Circle userCircle = new Circle(radius);
                    userCircle.Radius = double.Parse(input);
                    Console.WriteLine("\nThe area of your circle is " + userCircle.CalculateFormattedArea());
                    Console.WriteLine("\nThe circumference of your circle is " + userCircle.CalculateFormattedCircumference());
                    amountOfCircles++;
                    runP = Continue(amountOfCircles);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out of range exception");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format exception");
                }
            }          
        }
        public static bool Continue(int amountOfCircles)
        {
            Console.WriteLine("\nWould you like to run the application again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;               
            }
            else if (input == "n")
            {
                Console.WriteLine("You created {0} circles, Thank you, Goodbye!", amountOfCircles);
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue(amountOfCircles);
            }
            return goOn;
        }
    }
}