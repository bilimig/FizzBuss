using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuss_KO
{
    internal class FizzBuzz
    {
        private int _x;
        public FizzBuzz() 
        {

        }

        public void FizzBuzzing()
        {
            Console.WriteLine("Podaj liczbe:");

            string input = Console.ReadLine();
            
            Console.Clear();
            
            int.TryParse(input, out _x);
            
            for(int i = 1; i <= _x; i++)
            {
                if(mod3(i) && mod5(i))
                {
                    Console.WriteLine("FizzBuzz");
                }
            
                else if(mod3(i))
                {
                    Console.WriteLine("Fizz");
                }
                
                else if (mod5(i)) {
                    Console.WriteLine("Buzz");
                }
                
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private bool mod3(int num)  
        {
            if (num % 3 == 0)
            {
                return true;
            }
            return false;
        }
        private bool mod5(int num)
        {
            if (num % 5 == 0)
            {
                return true;
            }
            return false;
        }
    
    }
}
