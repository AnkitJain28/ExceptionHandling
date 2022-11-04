using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ArrayTypeMismatch
    {
       public static void Demo()
        {
            try
            {
                Console.WriteLine("Demo started.");   
                string[] array1 = { "cat", "dog", "fish" }; // Declares and assigns a string array.
                object[] array2 = array1;                   // ... Then implicitly casts to base class object.
                array2[0] = 5;                              // ... Then assigns invalid element.
            }
            catch(ArrayTypeMismatchException ex )
            { 
                Console.WriteLine("ArrayTypeMismatchException : " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Demo terminated.");
                Console.WriteLine();
            }
        }
    }
}
