using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main()
        {
            
        }
        static int Add(int num1, int num2)
        {
            num1 = 2;
            num2 = 5;
            return num1 + num2;
        }
        static int Add(int num1, int num2, decimal dec1, decimal dec2)
        {
            dec1 = 2.1m;
            dec2 = 3.2m;
            int num3 = Decimal.ToInt32(dec1);
            int num4 = Decimal.ToInt32(dec2);
            return num1 + num2 + num3 + num4;
        }

        static int Add(int num1, int num2, int num3, int num4, int num5, int num6, decimal dec1, decimal dec2, bool truth1)
        {
            Console.WriteLine("Please give a number...");
            num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give another number...");
            num6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this true or false?");
            truth1 = Convert.ToBoolean(Console.ReadLine());
            return num5 + num6;
            int sum = num5 + num6;
            if (truth1 == true )
            {
                Console.WriteLine(sum);
                if (sum == 1)
                {
                    Console.WriteLine($"{sum} dollar");
                }
                else
                {
                    Console.WriteLine($"{sum} dollars");
                }
            

            }
        }
    }
}
