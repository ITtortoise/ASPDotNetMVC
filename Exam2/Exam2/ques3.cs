//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Text;

//namespace Exam2
//{
//    public class ques3
//    {
//        static void Main()
//        {
//            var n = int.Parse(Console.ReadLine());
//            int temp = n - 1;
//            int i, j;
//            for (i = 0; i < n; i++)
//            {
//                for (j = 0; j < temp; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (j = 0; j <= i; j++)
//                {
//                    Console.Write("* ");
//                }
//                Console.WriteLine();
//                temp--;
//            }
//            temp = 0;
//            for (i = n; i > 0; i--)
//            {
//                for (j = 0; j < temp; j++)
//                {
//                    Console.Write(" ");
//                }
//                for (j = 0; j < i; j++)
//                {
//                    Console.Write("* ");
//                }
//                Console.WriteLine();
//                temp++;
//            }

//        }
//    }
//}
