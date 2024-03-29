﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Default parametr values
            ShowDate(DateTime.Now.Day, DateTime.Now.Month);
            ShowDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            #endregion

            #region Ref and Out keywords
            int num1 = 0; //(stack'da yarandi)
            SetRef(ref num1); //num1 deyeri 10 olacaq

            //int num2 = 0; //(7.0-dan once bele yazilmali idi)
            int num2; //(7.0-dan sonra bele yazila biler)
            SetOut(out num2);
            #endregion

            #region Flexible sayda parametr almaq
            Addition(15, 20, 56, 1551, 4888, 799, 46);
            Addition(15, 20, 56, 1551, 4888, 799, 46, 56, 1551, 4888, 799, 46, 455, 988);
            Addition(15, 20, 56, 1551, 4888, 799, 15, 20, 56, 1551, 4888, 799, 46, 4888, 799, 46, 455, 988);
            #endregion

            #region Overloading
            AdditionNums(5, 5);
            AdditionNums(2.4m, 5.5m);
            AdditionNums("10.2", "20.5");
            #endregion

            #region Use method as parameter
            //uzun versiya
            decimal s = Subtraction(15.5m, 2.5m);
            ShowValue(s);

            //qisa versiya
            ShowValue(Subtraction(15.5m, 2.5m));
            #endregion

            #region Local Functions
            AdditionWithLocalFunc(20, 15);
            SecondAdditionWithLocalFunc(10, 20, 30, 40);
            ThirdAdditionWithLocalFunc(10, 20, 30, 40);
            #endregion
        }


        #region Default parametr values
        public static void ShowDate(int day, int month, int year = 2024) //year burada default value'su olan parametrdir
        {
            Console.WriteLine("Tarix: {0}.{1}.{2}", day, month, year);
        }
        #endregion

        #region Ref and Out keywords
        static void SetRef(ref int intValue)
        {
            intValue = 10;
        }

        static void SetOut(out int intValue)
        {
            intValue = 15;
        }
        #endregion

        #region Flexible sayda parametr almaq
        static void Addition(params int[] numbers)
        {
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("Toplam: {0}", total);


            Console.WriteLine("Toplam: {0}", numbers.Sum());
        }
        //yanlis: static void Addition(params int[] numbers, string test)
        //dogru: static void Addition(int a, string name, params int[] numbers)
        #endregion
            
        #region Overloading
        static void AdditionNums(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine(total);
        }

        static void AdditionNums(string num1, string num2)
        {
            decimal total = decimal.Parse(num1) + decimal.Parse(num2);
            Console.WriteLine(total);
        }
        #endregion

        #region Use method as parameter
        static void ShowValue(decimal obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static decimal Subtraction(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        #endregion

        #region Local Functions
        static void AdditionWithLocalFunc(int num1, int num2)
        {
            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int result = Addition(num1, num2);
            Console.WriteLine(result);
        }

        static void SecondAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int Addition(int num1Local, int num2Local)
            {
                int SecondAddition(int num3Local, int num4Local)
                {
                    return num3Local + num4Local;
                }
                int result = SecondAddition(num3, num4);

                return result + num1Local + num2Local;
            }

            int total = Addition(num1, num2);

            Console.WriteLine(total);
        }

        //(daha seliqeli)
        static void ThirdAdditionWithLocalFunc(int num1, int num2, int num3, int num4)
        {
            int total = 0;

            int Addition(int num1Local, int num2Local)
            {
                return num1Local + num2Local;
            }

            int SecondAddition(int num3Local, int num4Local)
            {
                return num3Local + num4Local;
            }

            total += Addition(num1, num2);
            total += SecondAddition(num3, num4);

            Console.WriteLine(total);
        }
        #endregion
    }
}
