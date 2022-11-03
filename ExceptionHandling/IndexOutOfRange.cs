using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class IndexOutOfRange
    {
        public static void Demo()
        {
            try
            {
                Console.WriteLine("Demo started.");
                int[] array1 = {1, 2, 3 };
                Console.WriteLine(array1[3]);
            }
            catch (IndexOutOfRangeException IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException : " + IndexOutOfRangeException.Message);

            }

            finally
            {
                Console.WriteLine("Demo terminated.");
            }
        }
    }
}
