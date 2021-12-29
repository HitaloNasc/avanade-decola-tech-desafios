using System;

class DIO
{

    static void Main(string[] args)
    {

        int x = int.Parse(Console.ReadLine());
        if (x == 0)
        {
            Console.WriteLine(2);
        }
        else if (x % 2 != 0 && x != 0)
        {
            Console.WriteLine(x + 1);
        }
        else
        {
            Console.WriteLine(x + 2);
        }
    }

}