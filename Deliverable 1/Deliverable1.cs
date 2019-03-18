using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string uSD;
            string jD;
            string sD;
            string tD;

            Console.WriteLine("Please enter three numbers:");
            var num1 = float.Parse(Console.ReadLine());
            var num2 = float.Parse(Console.ReadLine());
            var num3 = float.Parse(Console.ReadLine());

            float totNum = (num1 + num2 + num3);
            Console.WriteLine("The total number is " + totNum);

            float avNum = (totNum) / 3;
            Console.WriteLine("The average number is " + avNum);

            if (num1 > num2 && num1 > num2)
            {
                Console.WriteLine(num1 + " is the highest number");
            }
                        else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is the highest number");
            }
            else
            {
                Console.WriteLine(num3 + " is the highest number");
            }

            if (num1 < num2 && num1 < num2)

            {
                Console.WriteLine(num1 + " is the lowest number");
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine(num2 + " is the lowest number");
            }
            else
            {
                Console.WriteLine(num3 + " is the lowest number");
            }

            uSD = totNum.ToString("C2");
            jD = totNum.ToString("C0", CultureInfo.CreateSpecificCulture("ja-JP"));
            sD = totNum.ToString("C2", CultureInfo.CreateSpecificCulture("sv-SEK"));
            tD = totNum.ToString("C2", CultureInfo.CreateSpecificCulture("th-THB"));

            Console.WriteLine("US Dollar: " + uSD);
            Console.WriteLine("Japanese Yen: " + jD);
            Console.WriteLine("Swidish Krona: " + sD);
            Console.WriteLine("Thailand Baht: " + tD);

        }
    } 
}
