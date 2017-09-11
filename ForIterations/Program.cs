using System;

namespace ForIterations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10, i++)
                // create variable "i" with an initial value of 0
                // evaluate as: is it true that "i" is less than 10?
                // increment operator, i = i + 1
            {
                //Console.WriteLine(i.ToString());

                if (i == 7)
                    // not sure how to show the value on the Mac...
                    // How to pin down a variable to watch it
                {
                    Console.WriteLine("Found seven!");
                    break;
                    // break out of code with the break statement, end the for
                    // jumps right out, bottom line of code now
                }

            } // execute block of code above until i < 10 is no longer true


            // Code Snipets - for (tab)

            for (int myValue = 0; myValue < 12;myValue++)
            {
                Console.WriteLine(myValue);
            }


            Console.ReadLine();
        }
    }
}
