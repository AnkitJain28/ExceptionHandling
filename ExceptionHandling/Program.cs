// See https://aka.ms/new-console-template for more information
using System;
namespace ExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayTypeMismatch.Demo();
            DivideByZero.Demo();
            IndexOutOfRange.Demo();
            InvalidCast.Demo();
            InputOutput.Demo();
            NullReference.Demo();
            OutOfMemory.Demo();
            //StackOverflow.Demo();

        }
    }
}
