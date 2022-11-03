using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class OutOfMemory
    {
        public static void Demo()
        {
            try
            {
                Console.WriteLine("Demo started.");
                StringBuilder sb = new StringBuilder(15, 15);
                sb.Append("Substring #1 ");
                sb.Insert(0, "Substring #2 ", 1);
            }
            catch (OutOfMemoryException OutofMemoryException)
            {
                Console.WriteLine("OutOfMemoryException : " + OutofMemoryException.Message);

            }

            finally
            {
                Console.WriteLine("Demo terminated.");
            }
        }
    }
}
