﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
        BeginAgain:
            Console.Clear();
            calc.ShowMenu();

            int userChoose = int.Parse(Console.ReadLine());

            Console.WriteLine("Birinci deyeri daxil edin: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Ikinci deyeri daxil edin: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal result = 0;
            string mathOperator = "";

            switch (userChoose)
            {
                case 1:
                    result = calc.Addition(num1, num2);
                    mathOperator = "+";
                    break;
                case 2:
                    result = calc.Subtraction(num1, num2);
                    mathOperator = "-";
                    break;
                case 3:
                    result = calc.Divide(num1, num2);
                    mathOperator = "/";
                    break;
                case 4:
                    result = calc.Multiplication(num1, num2);
                    mathOperator = "*";
                    break;
                default:
                    Console.WriteLine("Yanlis deyer daxil etdiniz!");
                    Console.WriteLine("Xahis olunur yeniden cehd edin.");
                    goto BeginAgain;
            }

            calc.ShowResult(num1, num2, result, mathOperator);

            Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz? (H/Y)");

            string answer = Console.ReadLine();

            if (answer.ToUpper() == "H")
                goto BeginAgain;

            Console.ReadLine();
        }
    }
}
