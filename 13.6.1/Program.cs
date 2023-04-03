using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;

namespace _13._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var time = Stopwatch.StartNew(); 
            
            LinkedList<string> listLinked = new LinkedList<string>();
            listLinked.AddFirst(File.ReadAllText("C:/Users/Fender/Desktop/Text1.txt"));
            Console.WriteLine($"Производительность с использованием LinkedList<T> составила: {time.Elapsed.TotalMilliseconds}  мс.");
            Console.WriteLine();

            List<string> list = new List<string>();
            list = File.ReadLines("C:/Users/Fender/Desktop/Text1.txt").ToList();
            Console.WriteLine($"Производительность с использованием List<T> составила:{ time.Elapsed.TotalMilliseconds}  мс.");


        }
    }
}
