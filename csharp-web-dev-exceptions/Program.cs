using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        // returns x divided y
        // throws error when attempting to divide by 0
        static double Divide(double x, double y)
        {
            // if we try to divide by zero, throw exception
            // if y is equal 0, throw exception
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Attempting to divide by zero");
            }
            return x / y;
        }

        // if the fileName ends in '.cs', return 1
        // if the fileName doesn't end in '.cs', return 0
        static int CheckFileExtension(string fileName)
        {
            // if fileName is empty or null, throw exception
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException();
            }
            else if (fileName.EndsWith(".cs"))
            {
                // fileName ends in .cs
                return 1;
            }
            // fileName doesn't end in .cs and isn't empty
            return 0;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            /*try
            {
                Console.WriteLine(Divide(1, 0));
            } catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Attempted to divide by zero");
            } finally
            {
                Console.WriteLine("This is the finally block executing");
            }

            try
            {
                Console.WriteLine(Divide(20, 5));
            } catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Attempted to divide by zero");
            } finally
            {
                Console.WriteLine("This is the finally block executing");
            }*/


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            students.Add("Pearce", "index.html");

            foreach(KeyValuePair<string, string> kvp in students)
            {
                try
                {
                    int score = CheckFileExtension(kvp.Value);
                    Console.WriteLine($"{kvp.Key}'s score: {score}");
                } catch (ArgumentNullException error)
                {
                    Console.WriteLine($"{kvp.Key} didn't provide a file.");
                    Console.WriteLine(error.Message);
                }
            }
        }
    }
}
