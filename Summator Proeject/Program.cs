using System;

namespace Summator_Proeject
{
    class Program
    {
        static void Main(string[] args)
        {
            int result  = Summator.Sum(new int[] { 1,2,3,4,5,6,});
            if(result == 21)
            {
                Console.WriteLine("Test Pass");
            } else
            {
                Console.WriteLine("Failed");
            }

            long average = Summator.Average(new int[] {5,10,15 });
            if (result == 10)
            {
                Console.WriteLine("Test Pass");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
