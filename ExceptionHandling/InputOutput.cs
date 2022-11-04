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
                //int num1;
                //Console.WriteLine("Enter an integer input :");
                //num1 = Convert.ToInt32(Console.ReadLine());
                File.Open("C:\\Users\\Ankit Jain\\Desktop\\Advanced", FileMode.Open);
            }
            catch (IOException IOException)
            {
                Console.WriteLine("IOException : " + IOException.Message);

            }

            finally
            {
                Console.WriteLine("Demo terminated.");
                Console.WriteLine();
            }
        }
    }
}
