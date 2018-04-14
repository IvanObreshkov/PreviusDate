using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviusDate
{
    class Program
    {

        static void Main()
        {
            Console.Write("Въведи ден: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Въведи месец: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Въведи година: ");
            int year = int.Parse(Console.ReadLine());

            if (day == 1 && month == 3)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    day = 29;
                    month--;
                }
                else
                {
                    day = 28;
                    month--;
                }
            }
            else if (day == 1 && month == 1)
            {
                day = 31;
                month = 12;
                year--;
            }
            else if (day == 1 && month == 2)
            {
                day = 31;
                month--;
            }
            else if (day > 1 && month == 2)
            {
                day--;
            }
            else if (day == 1 && month == 12 || month == 10 || month == 5)
            {
                day = 30;
                month--;
            }
            else if (day > 1 && month == 12 || month == 10 || month == 5)
            {
                day--;
            }
            else if (day == 1 && month == 4 || month == 6 || month == 11)
            {
                day = 31;
                month--;
            }
            else if (day > 1 && month == 4 || month == 6 || month == 11)
            {
                day--;
            }
            else if (day == 1 && month == 3)
            {
                day = 28;
                month--;
            }
            else if (day == 1 && month == 9)
            {
                day = 31;
                month--;
            }
            else if (day > 1 && month == 9)
            {
                day--;
            }
            else if (day == 1 && month == 8)
            {
                day = 31;
                month--;
            }
            else if (day > 1 && month == 8)
            {
                day--;
            }
            else if (day == 1 && month == 7)
            {
                day = 30;
                month--;
            }
            else if (day > 1 && month == 7)
            {
                day--;
            }


            Console.WriteLine("Предишната дата е: {0}/{1}/{2}", day, month, year);
        }
    }
}