using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace _13._6._2
{
    class Program
    {
        static List<string> StringList = new List<string>();
        static LinkedList<string> StringLinkList = new LinkedList<string>();
        static void Main(string[] args)
        {
            try
            {
                string Text = File.ReadAllText(@"C:\Users\Fender\Desktop\Text1(1).txt");

                var noPunctuationText = new string(Text.Where(c => !char.IsPunctuation(c)).ToArray());
                string[] Subs = noPunctuationText.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, int> Words = new Dictionary<string, int>();
                foreach (string item in Subs)
                {
                    if (Words.ContainsKey(item))
                    {
                        Words[item]++;
                    }
                    else
                    {
                        Words.Add(item, 1);
                    }
                }
                var top10 = Words.OrderByDescending(pair => pair.Value).Take(10);
                Console.WriteLine("10 слов, наиболее часто встречающихся в тексте:");
                Console.WriteLine("_______________________________________________");
                Console.WriteLine();
                foreach (var item in top10)
                {
                    Console.WriteLine($"Слово \'{item.Key}\'  встречается в тексте {item.Value} раз");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Неверный путь к файлу с текстом");
            }
        }
    }
}