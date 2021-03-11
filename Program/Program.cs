using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 0, y = 0;

            Console.WriteLine("Ingrese un valor para la variable X:");
            x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para la variable Y:");
            y = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"La suma de {x} + {y} es igual a {SubtractNumbers(x,y)}");

        }

        public static int SubtractNumbers(int x, int y)
        {
            return x-y;
        }
    }
}
