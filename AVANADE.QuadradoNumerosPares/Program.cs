using System;
class DIO
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}^2 = {1}", i, Math.Pow(i, 2));
            }
        }

    }

}