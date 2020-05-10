using BestPractices.Models;
using System;

namespace BestPractices
{
    class Program
    {
        public const int ConstantVariable = 100;
        public static readonly int ReadOnlyVariable = 0;

        /// <summary>
        /// ReadOnly variable can also be reassigned 
        /// in a constructor
        /// </summary>
        static Program()
        {
            ReadOnlyVariable = 7; 
        }

        static void Main(string[] args)
        {
            //var currentActor = new Actor();

            //currentActor.GetOccupation();

            Console.WriteLine(ReadOnlyVariable);
            Console.WriteLine(ConstantVariable);

        }
    }
}
