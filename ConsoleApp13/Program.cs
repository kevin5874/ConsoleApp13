using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            NameParams np = new NameParams();
            int x = 1;
            int y = 3;
            np.TwoParams(x, y);
            np.TwoParams(x: x, y: y);
            Console.ReadLine();
        }
    }
}
