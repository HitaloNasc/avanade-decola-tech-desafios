using System;

class DIO
{

    static void Main(string[] args)
    {

        string str;
        while ((str = Console.ReadLine()) != null)
        {
            if (int.Parse(str) == 0)
            {
                Console.WriteLine("vai ter copa!");
            }
            else
            {
                Console.WriteLine("vai ter duas!");
            }
        }

    }

}