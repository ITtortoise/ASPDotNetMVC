using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    public class ques1
    {
        static void Main(string[] args)
        {
            string name; int age; string city;
            var toupleList = new List<(int,string, string)>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <n; i++)
            {
                var line = Console.ReadLine().Split();
                name = line[0];
                age = int.Parse(line[1]);
                city = line[2];
                toupleList.Add((age,name,city));
            }
            toupleList.Sort();
            foreach (var item in toupleList)
            {
                Console.WriteLine($"{item.Item1} { item.Item2} { item.Item3}");
            }
        

        }
    }
}
