using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static void Add(int num1, int num2) 
        {
            Console.WriteLine(num1 + num2); 
        }
        public static void Add(decimal num3, decimal num4) 
        {
            Console.WriteLine(num3 + num4);
        }
        public static void Add(int num5, int num6, bool word) 
        {
            var sum = num5 + num6;  
            if (word == true && sum > 1)
            {
                Console.WriteLine($"{sum} dollars");
            }
            else if (word == true && sum == 1)
                {
                Console.WriteLine($"{sum} dollar");
                }
            else
            {
                return;
            }
        }
            
        
    }
}
