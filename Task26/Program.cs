using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\develop\\files\\input.txt";
            string[] lines = File.ReadAllLines(path);
            Regex word = new Regex(@"[^a-z|A-Z]+");
            MyHashSet<string, int> set = new MyHashSet<string, int>();
            for (int i = 0; i < lines.Length; i++)
            {
                string [] wordsInLine = word.Split(lines[i]);
                for (int j = 0; j < wordsInLine.Length; j++)
                {
                    set.Add(wordsInLine[j].ToLower());
                }
            }
            string[] mas = set.ToArrayK();
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }

        }
    }
}
