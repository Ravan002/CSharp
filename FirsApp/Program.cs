using System;

namespace FirstApp
{
    class Program
    {
        static void Main(String[] args)
        {
            int input;
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    input = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("You must enter interger numbers!!!");
                }
            }
            Console.Write("Enter second number: ");
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine(input + " + " + input2 + " = " + sum(input, input2));
        }
        public static int sum(int a,int b)
        {
            return a + b;
        }
    }
}
