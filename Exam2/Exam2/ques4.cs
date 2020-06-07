using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvingWithCSharp
{
    class ques4
    {
        static void BigSum(string a, string b, int l1, int l2)
        {
            string temp = "";
            if (l1 < l2)
            {
                temp = a;
                a = b;
                b = temp;
            }
            string a1 = ""; string b1 = "";
            for (int i = a.Length-1; i>=0; i--)
            {
                a1 += a[i];
            }
            for (int j = b.Length-1; j >=0; j--)
            {
                b1 += b[j];
            }

            while (b1.Length < a1.Length) a1 += '0';
            Console.WriteLine(a1 + " " + b1);

            int carry = 0;
            int sum = 0;
            string result = "";
            for (int i = 0; i < b.Length; i++)
            {
                sum = (int)(a[i] - '0') + (int)(b[i] - '0') + carry;
                int s = (sum % 10);
                result += (char)(s + '0');
                carry = sum / 10;

            }

            if (carry > 0)
                result += (char)(carry + '0');

            bool flag = false;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '0' && flag == false)
                    continue;
                else
                {
                    Console.Write(result[i]);
                    flag = true;
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                var lines = Console.ReadLine();

                if (lines == null) { break; }
                var line = lines.Split(' ');

                string a = line[0], b = line[1];
                int l1 = a.Length; int l2 = b.Length;
                
                BigSum(a, b, l1, l2);


            }
        }
    }
}
