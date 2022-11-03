using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class StackOverflow
    {
        public static void RecursiveCall()
        {
            RecursiveCall();
        }

        public static void Demo()
        {
            try
            {
                Console.WriteLine("Demo started.");
                RecursiveCall();
            }
            catch(StackOverflowException StackOverflowException)
            {
                Console.WriteLine("StackOverflowException:" + StackOverflowException.Message);
            }
            finally
            {
                Console.WriteLine("Demo terminated.");
            }
        }

    }
} 