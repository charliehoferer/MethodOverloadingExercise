using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main()
        {
            var num1 = 2;
            var num2 = 5;
            var dec1 = 2.1m;
            var dec2 = 3.2m;
            var num3 = Decimal.ToInt32(dec1);
            var num4 = Decimal.ToInt32(dec2);
            Console.WriteLine("Please give a number...");
            var num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give another number...");
            var num6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Is this true or false?");
            var truth1 = Convert.ToBoolean(Console.ReadLine());
            int sum = num5 + num6;
            if (truth1 == true)
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
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Add(int num1, int num2, int num3, int num4, decimal dec1, decimal dec2)
        {
            
            return num1 + num2 + num3 + num4;
        }

        public int Add(int num1, int num2, int num3, int num4, int num5, int num6, decimal dec1, decimal dec2, bool truth1)
        {
            
            return num5 + num6;
            
            
       
                
        }
    }
}
