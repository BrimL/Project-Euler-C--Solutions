using System;

namespace Luke.Euler.Solutions.Number0001
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = 0;
            
            for (int i = 1; i < 1000; i++) {
                if (((i % 3) == 0) || ((i % 5) == 0)) {
                    result += i;
                }
            }
                           
            Console.WriteLine("The answer is:{0}", result);
        }
    }
}