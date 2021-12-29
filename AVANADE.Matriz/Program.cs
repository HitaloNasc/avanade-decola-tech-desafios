using System;

class DIO
{

    static void Main(string[] args)
    {

        for (int i = 1; i <= 9; i++)
        {
            if (i % 2 != 0)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
            }
        }
    }

}