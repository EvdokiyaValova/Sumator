using System;

namespace Sumator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long result = Sumator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });            

            if (result == 21 )
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}
