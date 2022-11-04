using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class DivideByZero
    {
        public static void Demo()
        {
            
            try
			{
                Console.WriteLine("Demo started.");
                int num1 = 10;
                int num2 = 0;
                int num3 = num1/num2;
			}
			catch (DivideByZeroException DivideByZeroException)
			{
				Console.WriteLine("DivideByZeroException : " + DivideByZeroException.Message);
			}

			finally
			{
                Console.WriteLine("Demo terminated.");
                Console.WriteLine();
            }
        }
    }
}
