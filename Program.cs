using System;
using System.Linq;

namespace DaySixAssignment
{
    internal class Program
    {
        private static void FibonacciSeriesProgram()
        {
            int a = 0, b = 1;
            string series = $"{a}, {b}";

            Console.Write("insert max length of fibonacci series: ");
            int limit = Convert.ToInt16(Console.ReadLine()) - 2;
            for (int i = 0; i < limit; i++)
            {
                int temp = a + b; a = b; b = temp; series += $", {temp}";
            }
            Console.WriteLine(series);
        }
        private static void PerfectNumberProgram()
        {
            string series = "";
            int perfectNumberSum = 0;
            Console.Write("Insert a number for perfect number check: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    series += $"{i} ";
                    perfectNumberSum += i;
                }
            }
            if (num == perfectNumberSum)
            {
                Console.WriteLine(series);
                Console.WriteLine($"{num} is a perfect number");
            }
            else Console.WriteLine($"{num} is not a perfect number");
        }
        private static void PrimeNumberProgram()
        {
            bool isPrime = false;
            string series = "1";
            Console.Write("Insert a number for prime number check: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 1)
            {
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0) series += $" {i}";
                }
            }
            if (series.Length == 3) isPrime = true;
            Console.WriteLine(isPrime ? $"{num} is Prime number" : $"{num} not a Prime no");
        }
        private static void ReverseNumberProgram()
        {
            int num, rev = 0;
            Console.Write("Insert a number to generate reverse: ");
            int temp = num = Convert.ToInt32(Console.ReadLine());
            while (temp > 0)
            {
                int remainder = temp % 10;
                rev = (rev * 10) + remainder;
                temp /= 10;
            }
            Console.WriteLine($"{rev} is reverse of {num}");
        }
        private static void CouponNumbersProgram()
        {
            Random random = new Random();
            int counter = 0;
            void InsertValue(int position, int[] arr, int arrLen)
            {
                int max = 110;
                int min = 100;
                while (max-min > arrLen)
                {
                    int value = random.Next(min, max);
                    counter++;
                    if (arr.Contains(value)) continue;
                    else
                    {
                        arr[position] = value;
                        break;
                    }
                }
                Console.WriteLine($"no. of  coupons {arrLen} is less than range {min}-{max}");
            }
            Console.Write("Insert a number of coupons to generate: ");
            int arrLen = Convert.ToInt32(Console.ReadLine());
            int[] couponsArray = new int[arrLen];
            for (int i = 0; i < arrLen; i++)
            {
                InsertValue(i, couponsArray, arrLen);
            }

            Console.WriteLine($"Counter is {counter}");
            foreach (int i in couponsArray) Console.WriteLine(i);
        }
        private static void VendingMachineProgram()
        {
            Console.Write("Insert your cash ammount: ");
            int cash = Convert.ToInt32(Console.ReadLine());
            int tempCash = cash; //50
            int[] revAvailableCash = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            for (int i = 0; i < revAvailableCash.Length; i++)
            {
                if (cash >= revAvailableCash[i])
                {
                    int noOfNotes = cash / revAvailableCash[i];
                    cash %= revAvailableCash[i];
                    Console.WriteLine($"{revAvailableCash[i]} x {noOfNotes}");
                }
                if (cash == 0) break;
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"total\t= {tempCash}");
        }
        private static void DayOfWeek()
        {
            // int d = 21, m = 9, y = 1994;
            Console.Write("Insert Day: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Month: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Year: ");
            int y = Convert.ToInt32(Console.ReadLine());
            string month = "", day = "";
            int y0 = y - ((14 - m) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = (m + (12 * ((14 - m) / 12)) - 2);
            int d0 = (d + x + ((31 * m0) / 12)) % 7;

            switch (m0)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;
                case 12:
                    month = "December";
                    break;
            }
            switch (d0)
            {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;

            }
            Console.WriteLine($"{day}-{month}");
        }
        private static void TemperatureConversion()
        {
            double result = 0;
            Console.Write("insert temperature = ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.Write("insert scale C/F: ");
            string tempType = Console.ReadLine();
            if (tempType.ToLower() == "c") result = (temp - 32) * 0.56;
            if (tempType.ToLower() == "f") result = (temp * 1.8) + 32;
            Console.WriteLine("result: " + result);
        }
        private static void MonthlyPayment()
        {
            Console.Write("Enter Principal loan ammount = ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter years to pay = ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter rate of interest = ");
            double R = Convert.ToDouble(Console.ReadLine());
            double n = 12 * Y;
            double r = (R / (12 * 100));
            var payment = (P * r) / (1 - Math.Pow((1 + r), (-1 * n)));
            Console.WriteLine($"you have to pay {payment}/m");
        }
        private static void ToBinary()
        {
            Console.Write("Enter a number to convert into binary = ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            string result = string.Empty;
            while (num > 0)
            {
                int remainder = num % 2;
                num /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine($"{temp} in binary is {result}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Assignments");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>Logical Programs>>>>>>>>>>>>>>>>>>");
            // FibonacciSeriesProgram();                   // Part 1: Question 01
            // PerfectNumberProgram();                     // Part 1: Question 02
            // PrimeNumberProgram();                       // Part 1: Question 03
            // ReverseNumberProgram();                     // Part 1: Question 04
            CouponNumbersProgram();                     // Part 1: Question 05

            Console.WriteLine(">>>>>>>>>>>>>>>>>>Programs for NUnit Testing>>>>>>>>>>>>>>>>>>");
            // VendingMachineProgram();                    // Part 2: Question 01
            // DayOfWeek();                                // Part 2: Question 02
            // TemperatureConversion();                    // Part 2: Question 03
            // MonthlyPayment();                           // Part 2: Question 04
            // ToBinary();                                 // Part 2: Question 06
        }
    }
}
