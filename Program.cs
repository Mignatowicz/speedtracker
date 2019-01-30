using System;

namespace speedtracker
{
    class Program
    {
        static void Main(string[] args)
        {
            float speed = 0;
            float time1 = 0;
            float time2 = 0;
            float distance = 1;
            float difference = 0;


            Console.WriteLine("Enter Your first time (seconds)");
            time1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second time (seconds)");
            time2 = float.Parse(Console.ReadLine());
           

            if (time1 == time2)
            {
                time2 = float.Parse(Console.ReadLine());
            }

            else if (time2 > time1)
            {
                difference = time2 - time1;
            }

            else
            {
                difference = time1 - time2;
            }

            Console.WriteLine("The difference is: ");
            Console.WriteLine(difference);

            speed = distance / difference;

            Console.WriteLine("Your Time is: ");
            Console.WriteLine(speed);
            Console.WriteLine("(milliseconds)");

            

            Console.ReadKey();
        }
    }
}
