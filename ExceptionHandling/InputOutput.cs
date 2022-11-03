using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InputOutput
    {
        public static void Demo()
        {
            try
            {
                Console.WriteLine("Demo started.");
            }
            catch (IOException IOException)
            {
                Console.WriteLine("IOException : " + IOException.Message);

            }

            finally
            {
                Console.WriteLine("Demo terminated.");
            }
        }
    }
}
