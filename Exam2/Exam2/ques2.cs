using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Schema;

namespace Exam2
{
    public class _2ques
    {
        public static void Main()
        {
            //INPUT FORMAT FOR 24 TO 12 CONVERSION 00:00 (no space)
            //INPUT FORMAT FOR 12 TO 24 CONVERSION 00:00AM OR 00:00PM (no space)
            Console.WriteLine("Press 1 for convert time 24 hour to 12 hour OR press 2 for convert time 12 hour to 24 hour && press 3 for terminate :");
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            var line = Console.ReadLine().Split(':');
                            int h = int.Parse(line[0]);
                            int m = int.Parse(line[0]);
                            if (h <= 12)
                                Console.WriteLine($"{h}:{m} AM");
                            else
                                Console.WriteLine($"{h - 12}:{m} PM");

                            break;
                        }
                    case 2:
                        {
                            var line = Console.ReadLine();
                            var h = ""; var m = ""; var t = "";
                            h += line[0]; h += line[1];
                            m += line[3]; m += line[4];
                            t += line[5]; t += line[6];
                            int hour = int.Parse(h);
                            int minute = int.Parse(m);
                            if (t == "AM")
                                Console.WriteLine($"{h}:{m}");
                            else
                            {
                                Console.WriteLine($"{hour + 12}:{m}");
                            }
                            break;
                        }
                    case 3:
                        break;


                }
            }
        }
    }
}
