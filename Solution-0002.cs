using System;

namespace Luke.Euler.Solutions.Number0002
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long result=0;
            long temp=0;
            long num1=1;
            long num2=1;
            
            while(temp < 4000000){
                if((temp % 2) == 0){
                    result += temp;
                }

                temp=num1 +num2;
                num2=num1;
                num1=temp;
            }
                           
            Console.WriteLine("The answer is:{0}", result);
        }
    }
}