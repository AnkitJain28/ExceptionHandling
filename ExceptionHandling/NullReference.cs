using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NullReference
    {
        public static void Demo()
        {
            try
            {
                Console.WriteLine("Demo started.");
                int[] array = null;
                array[0] = 0;
            }
            catch (NullReferenceException NullReferenceException)
            {
                Console.WriteLine("NullRefernceException : " + NullReferenceException.Message);

            }

            finally
            {
                Console.WriteLine("Demo terminated.");
                Console.WriteLine();
            }
        }
    }
}
