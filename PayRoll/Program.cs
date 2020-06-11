using System;

namespace PayRoll
{
    class Program
    { 
       static double hours = 0;

       static double rate = 0;
        static void Main(string[] args)
        {
            beginning:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("how many hours did you work");
            hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the pay rate");
            rate= Convert.ToDouble(Console.ReadLine());
            if( hours > 40)
            {
                Overtime();
            }
            else if (hours <= 40)
            {
                Pay();
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to do another pay check ? (y / n)"); // prompts user if they want to run again

            if (Console.ReadLine().ToLower() != "y")
            { }
            else
            {

                goto beginning;
            }

        }

        static void Pay()
        {
            Console.WriteLine("your pay is $" + hours*rate) ;

        }
        static void Overtime()

        {
            Console.WriteLine("your overtime pay is $" + ((rate*40)+rate*1.5*(hours-40))) ;

        }
       
    }

}
