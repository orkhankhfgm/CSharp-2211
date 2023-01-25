﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeModule1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                3. Local function'lar yaradaraq bir kalkulyator yaradın.
             */
            
            Calculate("5", 5m, "+");
        }

        #region Version 1
        //static void Calculate(int a, int b, string oper)
        //{
        //    decimal Addition(decimal addA, decimal addB)
        //    {
        //        decimal resultAdd = addA + addB;
        //        return resultAdd;
        //    }

        //    decimal Subtraction(decimal subA, decimal subB)
        //    {
        //        decimal resultSub = subA - subB;
        //        return resultSub;
        //    }

        //    decimal Multiplication(decimal mulA, decimal mulB)
        //    {
        //        decimal resultMul = mulA - mulB;
        //        return resultMul;
        //    }

        //    decimal Divide(decimal divA, decimal divB)
        //    {
        //        if(divB != 0)
        //        {
        //            decimal resultDiv = divA - divB;
        //            return resultDiv;
        //        }
        //        else
        //            Console.WriteLine("Bolen 0 ola bilmez!");

        //        return 0;
        //    }

        //    decimal Percent(decimal perA, decimal perB)
        //    {
        //        decimal resultPer = (perA * perB) / 100;
        //        return resultPer;
        //    }

        //    decimal Rate(decimal rateA, decimal rateB)
        //    {
        //        decimal resultRate = (rateA * 100) / rateB;
        //        return resultRate;
        //    }

        //    switch (oper)
        //    {
        //        case "+" :

        //            decimal resultAdditions = Addition(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b , resultAdditions);
        //            break;

        //        case "-":
        //            decimal resultSubtractions = Subtraction(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtractions);
        //            break;

        //        case "*":
        //            decimal resultMultiplications = Multiplication(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiplications);
        //            break;

        //        case "/":
        //            decimal resultDivides = Divide(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivides);
        //            break;

        //        case "%":
        //            decimal resultPercents = Percent(a, b);
        //            Console.WriteLine("{0}-in {1} {2}-i {3} beraberdir", a, b, oper, resultPercents);
        //            break;

        //        case "%%":
        //            decimal resultresultRates = Rate(a, b);
        //            Console.WriteLine("{0} {1}-in {2} faizine beraberdir", a, b, resultresultRates);
        //            break;

        //        default:
        //            break;
        //    }
        //}

        //static void Calculate(decimal a, decimal b, string oper)
        //{
        //    decimal Addition(decimal addA, decimal addB)
        //    {
        //        decimal resultAdd = addA + addB;
        //        return resultAdd;
        //    }

        //    decimal Subtraction(decimal subA, decimal subB)
        //    {
        //        decimal resultSub = subA - subB;
        //        return resultSub;
        //    }

        //    decimal Multiplication(decimal mulA, decimal mulB)
        //    {
        //        decimal resultMul = mulA - mulB;
        //        return resultMul;
        //    }

        //    decimal Divide(decimal divA, decimal divB)
        //    {
        //        if (divB != 0)
        //        {
        //            decimal resultDiv = divA - divB;
        //            return resultDiv;
        //        }
        //        else
        //            Console.WriteLine("Bolen 0 ola bilmez!");

        //        return 0;
        //    }

        //    decimal Percent(decimal perA, decimal perB)
        //    {
        //        decimal resultPer = (perA * perB) / 100;
        //        return resultPer;
        //    }

        //    decimal Rate(decimal rateA, decimal rateB)
        //    {
        //        decimal resultRate = (rateA * 100) / rateB;
        //        return resultRate;
        //    }

        //    switch (oper)
        //    {
        //        case "+":

        //            decimal resultAdditions = Addition(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
        //            break;

        //        case "-":
        //            decimal resultSubtractions = Subtraction(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtractions);
        //            break;

        //        case "*":
        //            decimal resultMultiplications = Multiplication(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiplications);
        //            break;

        //        case "/":
        //            decimal resultDivides = Divide(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivides);
        //            break;

        //        case "%":
        //            decimal resultPercents = Percent(a, b);
        //            Console.WriteLine("{0}-in {1} {2}-i {3} beraberdir", a, b, oper, resultPercents);
        //            break;

        //        case "%%":
        //            decimal resultresultRates = Rate(a, b);
        //            Console.WriteLine("{0} {1}-in {2} faizine beraberdir", a, b, resultresultRates);
        //            break;

        //        default:
        //            break;
        //    }
        //}

        //static void Calculate(string a, string b, string oper)
        //{
        //    decimal Addition(decimal addA, decimal addB)
        //    {
        //        decimal resultAdd = addA + addB;
        //        return resultAdd;
        //    }

        //    decimal Subtraction(decimal subA, decimal subB)
        //    {
        //        decimal resultSub = subA - subB;
        //        return resultSub;
        //    }

        //    decimal Multiplication(decimal mulA, decimal mulB)
        //    {
        //        decimal resultMul = mulA - mulB;
        //        return resultMul;
        //    }

        //    decimal Divide(decimal divA, decimal divB)
        //    {
        //        if (divB != 0)
        //        {
        //            decimal resultDiv = divA - divB;
        //            return resultDiv;
        //        }
        //        else
        //            Console.WriteLine("Bolen 0 ola bilmez!");

        //        return 0;
        //    }

        //    decimal Percent(decimal perA, decimal perB)
        //    {
        //        decimal resultPer = (perA * perB) / 100;
        //        return resultPer;
        //    }

        //    decimal Rate(decimal rateA, decimal rateB)
        //    {
        //        decimal resultRate = (rateA * 100) / rateB;
        //        return resultRate;
        //    }

        //    switch (oper)
        //    {
        //        case "+":

        //            decimal resultAdditions = Addition(decimal.Parse(a), decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
        //            break;

        //        case "-":
        //            decimal resultSubtractions = Subtraction(decimal.Parse(a), decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtractions);
        //            break;

        //        case "*":
        //            decimal resultMultiplications = Multiplication(decimal.Parse(a), decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiplications);
        //            break;

        //        case "/":
        //            decimal resultDivides = Divide(decimal.Parse(a), decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivides);
        //            break;

        //        case "%":
        //            decimal resultPercents = Percent(decimal.Parse(a), decimal.Parse(b));
        //            Console.WriteLine("{0}-in {1} {2}-i {3} beraberdir", a, b, oper, resultPercents);
        //            break;

        //        case "%%":
        //            decimal resultresultRates = Rate(decimal.Parse(a), decimal.Parse(b));
        //            Console.WriteLine("{0} {1}-in {2} faizine beraberdir", a, b, resultresultRates);
        //            break;

        //        default:
        //            break;
        //    }
        //}

        //static void Calculate(string a, decimal b, string oper)
        //{
        //    decimal Addition(decimal addA, decimal addB)
        //    {
        //        decimal resultAdd = addA + addB;
        //        return resultAdd;
        //    }

        //    decimal Subtraction(decimal subA, decimal subB)
        //    {
        //        decimal resultSub = subA - subB;
        //        return resultSub;
        //    }

        //    decimal Multiplication(decimal mulA, decimal mulB)
        //    {
        //        decimal resultMul = mulA - mulB;
        //        return resultMul;
        //    }

        //    decimal Divide(decimal divA, decimal divB)
        //    {
        //        if (divB != 0)
        //        {
        //            decimal resultDiv = divA - divB;
        //            return resultDiv;
        //        }
        //        else
        //            Console.WriteLine("Bolen 0 ola bilmez!");

        //        return 0;
        //    }

        //    decimal Percent(decimal perA, decimal perB)
        //    {
        //        decimal resultPer = (perA * perB) / 100;
        //        return resultPer;
        //    }

        //    decimal Rate(decimal rateA, decimal rateB)
        //    {
        //        decimal resultRate = (rateA * 100) / rateB;
        //        return resultRate;
        //    }

        //    switch (oper)
        //    {
        //        case "+":

        //            decimal resultAdditions = Addition(decimal.Parse(a), b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
        //            break;

        //        case "-":
        //            decimal resultSubtractions = Subtraction(decimal.Parse(a), b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtractions);
        //            break;

        //        case "*":
        //            decimal resultMultiplications = Multiplication(decimal.Parse(a), b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiplications);
        //            break;

        //        case "/":
        //            decimal resultDivides = Divide(decimal.Parse(a), b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivides);
        //            break;

        //        case "%":
        //            decimal resultPercents = Percent(decimal.Parse(a), b);
        //            Console.WriteLine("{0}-in {1} {2}-i {3} beraberdir", a, b, oper, resultPercents);
        //            break;

        //        case "%%":
        //            decimal resultresultRates = Rate(decimal.Parse(a), b);
        //            Console.WriteLine("{0} {1}-in {2} faizine beraberdir", a, b, resultresultRates);
        //            break;

        //        default:
        //            break;
        //    }
        //}

        //static void Calculate(decimal a, int b, string oper)
        //{
        //    decimal Addition(decimal addA, decimal addB)
        //    {
        //        decimal resultAdd = addA + addB;
        //        return resultAdd;
        //    }

        //    decimal Subtraction(decimal subA, decimal subB)
        //    {
        //        decimal resultSub = subA - subB;
        //        return resultSub;
        //    }

        //    decimal Multiplication(decimal mulA, decimal mulB)
        //    {
        //        decimal resultMul = mulA - mulB;
        //        return resultMul;
        //    }

        //    decimal Divide(decimal divA, decimal divB)
        //    {
        //        if (divB != 0)
        //        {
        //            decimal resultDiv = divA - divB;
        //            return resultDiv;
        //        }
        //        else
        //            Console.WriteLine("Bolen 0 ola bilmez!");

        //        return 0;
        //    }

        //    decimal Percent(decimal perA, decimal perB)
        //    {
        //        decimal resultPer = (perA * perB) / 100;
        //        return resultPer;
        //    }

        //    decimal Rate(decimal rateA, decimal rateB)
        //    {
        //        decimal resultRate = (rateA * 100) / rateB;
        //        return resultRate;
        //    }

        //    switch (oper)
        //    {
        //        case "+":

        //            decimal resultAdditions = Addition(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
        //            break;

        //        case "-":
        //            decimal resultSubtractions = Subtraction(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtractions);
        //            break;

        //        case "*":
        //            decimal resultMultiplications = Multiplication(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiplications);
        //            break;

        //        case "/":
        //            decimal resultDivides = Divide(a, b);
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivides);
        //            break;

        //        case "%":
        //            decimal resultPercents = Percent(a, b);
        //            Console.WriteLine("{0}-in {1} {2}-i {3} beraberdir", a, b, oper, resultPercents);
        //            break;

        //        case "%%":
        //            decimal resultresultRates = Rate(a, b);
        //            Console.WriteLine("{0} {1}-in {2} faizine beraberdir", a, b, resultresultRates);
        //            break;

        //        default:
        //            break;
        //    }
        //}

        //static void Calculate(int a, string b, string oper)
        //{
        //    decimal Addition(decimal addA, decimal addB)
        //    {
        //        decimal resultAdd = addA + addB;
        //        return resultAdd;
        //    }

        //    decimal Subtraction(decimal subA, decimal subB)
        //    {
        //        decimal resultSub = subA - subB;
        //        return resultSub;
        //    }

        //    decimal Multiplication(decimal mulA, decimal mulB)
        //    {
        //        decimal resultMul = mulA - mulB;
        //        return resultMul;
        //    }

        //    decimal Divide(decimal divA, decimal divB)
        //    {
        //        if (divB != 0)
        //        {
        //            decimal resultDiv = divA - divB;
        //            return resultDiv;
        //        }
        //        else
        //            Console.WriteLine("Bolen 0 ola bilmez!");

        //        return 0;
        //    }

        //    decimal Percent(decimal perA, decimal perB)
        //    {
        //        decimal resultPer = (perA * perB) / 100;
        //        return resultPer;
        //    }

        //    decimal Rate(decimal rateA, decimal rateB)
        //    {
        //        decimal resultRate = (rateA * 100) / rateB;
        //        return resultRate;
        //    }

        //    switch (oper)
        //    {
        //        case "+":

        //            decimal resultAdditions = Addition(a, decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
        //            break;

        //        case "-":
        //            decimal resultSubtractions = Subtraction(a, decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtractions);
        //            break;

        //        case "*":
        //            decimal resultMultiplications = Multiplication(a, decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiplications);
        //            break;

        //        case "/":
        //            decimal resultDivides = Divide(a, decimal.Parse(b));
        //            Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivides);
        //            break;

        //        case "%":
        //            decimal resultPercents = Percent(a, decimal.Parse(b));
        //            Console.WriteLine("{0}-in {1} {2}-i {3} beraberdir", a, b, oper, resultPercents);
        //            break;

        //        case "%%":
        //            decimal resultresultRates = Rate(a, decimal.Parse(b));
        //            Console.WriteLine("{0} {1}-in {2} faizine beraberdir", a, b, resultresultRates);
        //            break;

        //        default:
        //            break;
        //    }
        //}
        #endregion
        
        #region Version 2
        static void Calculate(decimal a, decimal b, string oper)
        {
            decimal Addition(decimal addA, decimal addB)
            {
                decimal resultAdd = addA + addB;
                return resultAdd;
            }

            decimal Subtraction(decimal subA, decimal subB)
            {
                decimal resultSub = subA - subB;
                return resultSub;
            }

            decimal Multiplication(decimal mulA, decimal mulB)
            {
                decimal resultMul = mulA - mulB;
                return resultMul;
            }

            decimal Divide(decimal divA, decimal divB)
            {
                if (divB != 0)
                {
                    decimal resultDiv = divA - divB;
                    return resultDiv;
                }
                else
                    Console.WriteLine("Bolen 0 ola bilmez!");

                return 0;
            }

            decimal Percent(decimal perA, decimal perB)
            {
                decimal resultPer = (perA * perB) / 100;
                return resultPer;
            }

            decimal Rate(decimal rateA, decimal rateB)
            {
                decimal resultRate = (rateA * 100) / rateB;
                return resultRate;
            }

            switch (oper)
            {
                case "+":

                    decimal resultAdditions = Addition(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;

                case "-":
                    decimal resultSubtractions = Subtraction(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtractions);
                    break;

                case "*":
                    decimal resultMultiplications = Multiplication(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiplications);
                    break;

                case "/":
                    decimal resultDivides = Divide(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivides);
                    break;

                case "%":
                    decimal resultPercents = Percent(a, b);
                    Console.WriteLine("{0}-in {1} {2}-i {3} beraberdir", a, b, oper, resultPercents);
                    break;

                case "%%":
                    decimal resultresultRates = Rate(a, b);
                    Console.WriteLine("{0} {1}-in {2} faizine beraberdir", a, b, resultresultRates);
                    break;

                default:
                    break;
            }
        }

        static void Calculate(int a, int b, string oper)
        {
            decimal _a = decimal.Parse(a.ToString());
            decimal _b = decimal.Parse(b.ToString());
            Calculate(_a, _b, oper);
        }

        static void Calculate(string a, string b, string oper)
        {
            decimal _a = decimal.Parse(a.ToString());
            decimal _b = decimal.Parse(b.ToString());
            Calculate(_a, _b, oper);
        }

        static void Calculate(string a, decimal b, string oper)
        {
            decimal _a = decimal.Parse(a.ToString());
            decimal _b = decimal.Parse(b.ToString());
            Calculate(_a, _b, oper);
        }

        static void Calculate(decimal a, int b, string oper)
        {
            decimal _a = decimal.Parse(a.ToString());
            decimal _b = decimal.Parse(b.ToString());
            Calculate(_a, _b, oper);
        }

        static void Calculate(int a, string b, string oper)
        {
            decimal _a = decimal.Parse(a.ToString());
            decimal _b = decimal.Parse(b.ToString());
            Calculate(_a, _b, oper);
        }
        #endregion
    }
}