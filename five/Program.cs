using System;

namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter two numbers");
            int maxnumber = Convert.ToInt32(Console.ReadLine());
            int minnumber = Convert.ToInt32(Console.ReadLine());
            for (int k = maxnumber; k > minnumber; k--)
            {
                if ((k % 10) == 5)
                {
                    int[] five = { k };
                    Console.WriteLine(k);
                    // Console.WriteLine(k);

                    // k++;

                    count++;
                }


            }
            Console.WriteLine("{0}",count);
            Console.ReadKey();
        }
    }
}
