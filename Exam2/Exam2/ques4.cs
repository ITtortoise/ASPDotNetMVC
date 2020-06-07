//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ProblemSolvingWithCSharp
//{
//    class ques4
//    {
//        static void BigSum(string a, string b)
//        {
//            string temp = "";
//            if (a.Length < b.Length)
//            {
//                temp = a;
//                a = b;
//                b = temp;
//            }
//            string a1 = ""; string b1 = "";
//            for (int i = a.Length - 1; i >= 0; i--)
//            {
//                a1 += a[i];
//            }
//            for (int j = b.Length - 1; j >= 0; j--)
//            {
//                b1 += b[j];
//            }

//            while (b1.Length < a1.Length) b1 += '0';
//            //Console.WriteLine(a1 + " " + b1);

//            int carry = 0;
//            int sum = 0;
//            string result = "";
//            for (int i = 0; i < b1.Length; i++)
//            {
//                sum = (int)(a1[i] - '0') + (int)(b1[i] - '0') + carry;
//                int s = (sum % 10);
//                result += (char)(s + '0');
//                carry = sum / 10;

//            }
//            string res = "";
//            if (carry > 0)
//                result += (char)(carry + '0');
//            for (int i = result.Length-1; i >= 0; i--)
//                res += result[i];

//            bool flag = false;
//            for (int i = 0; i < res.Length; i++)
//            {
//                if (res[i] == '0' && flag == false)
//                    continue;
//                else
//                {
//                    flag = true;
//                }
//            }
//            Console.WriteLine(res);
//        }
//        static void Main(string[] args)
//        {
            
//                var lines = Console.ReadLine();

//                var line = lines.Split(' ');

//                string a = line[0], b = line[1];
//                int l1 = a.Length; int l2 = b.Length;

//                BigSum(a, b);


            
//        }
//    }
//}
