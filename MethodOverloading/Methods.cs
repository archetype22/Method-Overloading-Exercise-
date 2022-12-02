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
        public static void Add(decimal num1, decimal num2) 
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Add(int num1, int num2, bool isMoney) 
        {
            var sum = num1 + num2;  
            if (isMoney == true && sum > 1)
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
