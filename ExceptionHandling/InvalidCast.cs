using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InvalidCast
    {
        public static void Demo()
        {
            try
            {
                Console.WriteLine("Demo started.");
                StringBuilder reference1 = new StringBuilder();
                object reference2 = reference1;
                StreamReader reference3 = (StreamReader)reference2;


            }
            catch (InvalidCastException InvalidCastException)
            {
                Console.WriteLine("Exception : " + InvalidCastException.Message);
            }

            finally
            {
                Console.WriteLine("Demo terminated.");
                Console.WriteLine();
            }
        }

    }
}
