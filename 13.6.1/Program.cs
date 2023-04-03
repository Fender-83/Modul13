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
            var timeLinkedList = Stopwatch.StartNew(); 
            LinkedList<string> listLinked = new LinkedList<string>();
            listLinked.AddFirst(File.ReadAllText("C:\\Users\\Fender\\Desktop\\Text1(1).txt"));
            var time1 = timeLinkedList.Elapsed.TotalSeconds;
            Console.WriteLine($"Производительность с использованием LinkedList<T> составила: {time1} мс.");
            Console.WriteLine();

            var timeList = Stopwatch.StartNew();
            List<string> list = new List<string>();
            list = File.ReadLines("C:\\Users\\Fender\\Desktop\\Text1(1).txt").ToList();
            var time2 = timeList.Elapsed.TotalSeconds;
            Console.WriteLine($"Производительность с использованием List<T> составила:{time2} мс.");

            Console.WriteLine();

            if ( time1 > time2 ) 
            {
            Console.WriteLine("Производительность LinkedList<T> больше, чем List<T> в " + Math.Round(time2 / time1,2) + " раз");
            }
            else
            {
            Console.WriteLine("Производительность LinkedList<T> меньше, чем List<T> в " + Math.Round(time2 / time1,2) + " раз");
            }
        }
    }
}
