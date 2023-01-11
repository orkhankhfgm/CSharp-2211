using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For loop
            ////Numune 1:
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Salam");
            //}
            //Console.Clear();

            ////Numune 2: 0-9
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////Numune 3: 1-10
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////Numune 4: 0-8
            //for (int i = 0; i < 10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            ////Numune 5:
            //for (int i = 0; i < 100; i+=10)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Clear();

            ////Numune 6:
            ////infinity loop
            ////for ( ; ; )
            ////{

            ////}

            ////Numune 7: infinity loop
            //int counter = 0;

            //for (; ;counter++)
            //{
            //    if (counter == 5)
            //        break;

            //    Console.WriteLine("Counter: " + counter);
            //}

            ////Numune 8:
            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine("Oneline for: " + i);

            ////Numune 9: break keyword
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        break;

            //    Console.WriteLine("Counter: " + i);
            //}

            //Console.Clear();

            ////Nested loop
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int x = 0; x < 10; x++)
            //    {
            //        Console.WriteLine("i:" + i + " --- x:" + x);
            //    }
            //    Console.WriteLine("_______________________");
            //}

            //Console.Clear();

            ////Numune 10: nested loop 2
            ////for (int a1 = 0; a1 < 10; a1++)
            ////{
            ////    for (int b1 = 0; b1 < 10; b1++)
            ////    {
            ////        for (int c1 = 0; c1 < 10; c1++)
            ////        {
            ////            for (int d1 = 0; d1 < 10; d1++)
            ////            {
            ////                Console.WriteLine("a:" + a1 + " --- " + "b:" + b1 + " --- " + "c:" + c1 + " --- " + "d:" + d1);
            ////            }
            ////        }
            ////    }
            ////}

            ////Numune 11: Yolka agaci
            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #region Task in Lesson 1
            ///*
            // Task 1: 1-den 100-e qeder olan reqemlerin toplamini ekrana yazdirin.
            // Task 2: Sadece cut reqemlerin toplamini ekrana yazdirin.
            // */

            //int result = 0;

            //for (int i = 1; i <= 100; i++)
            //    result += i;

            //Console.WriteLine("1-den 100-e qeder olan reqemlerin toplami: " + result);

            //result = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if ((i % 2) == 0)
            //        result += i;
            //}

            //result = 0;

            //for (int i = 0; i <= 100; i += 2)
            //    result += i;

            //Console.WriteLine("1-den 100-e qeder olan cut reqemlerin toplami: " + result);
            #endregion
            #endregion

            #region While loop
            Console.Clear();

            //Numune 1:
            //var continueLoop = true;

            //while (continueLoop)
            //{
            //    int sec = DateTime.Now.Second;

            //    if(sec >= 30 && sec <= 45)
            //    {
            //        Console.WriteLine("END");
            //        break;
            //    }
            //    else
            //        Console.WriteLine(sec);
            //}

            //Numune 2:
            //int countWhile = 1;

            //while (countWhile <= 100)
            //{
            //    Console.WriteLine("Counter: " + countWhile);
            //    countWhile++;
            //}

            #region Task in Lesson 2
            /*
             Belə bir kiçik app yazın ki, dayanmadan istifadəçidən bir text alın və istifadəçi text yerinə exit sözünü yazana qədər bu davam etsin.
             */

            //1-ci solution
            //while (true)
            //{
            //    string text = Console.ReadLine();

            //    if (text != "exit")
            //        Console.WriteLine(text);
            //    else
            //        break;
            //}

            //2-ci solution
            //var stopLoop = false;
            //while (!stopLoop)
            //{
            //    string text = Console.ReadLine();

            //    if (text != "exit")
            //        Console.WriteLine(text);
            //    else
            //        stopLoop = true;
            //}
            #endregion
            #endregion



            #region Do While Loop
            //bool startChat = false;

            //while (startChat)
            //{
            //    if(startChat == false)
            //    {
            //        Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        string answer = Console.ReadLine();

            //        if (answer == "He")
            //            startChat = true;
            //        else if (answer == "Yox")
            //            break;
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Sehv cavab daxil etdiniz!");
            //            Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mesaji daxil edin: ");
            //        string text = Console.ReadLine();

            //        if (text == "exit")
            //            break;

            //        Console.WriteLine(text);
            //    }
            //}



            //do
            //{
            //    if (startChat == false)
            //    {
            //        Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        string answer = Console.ReadLine();

            //        if (answer == "He")
            //            startChat = true;
            //        else if (answer == "Yox")
            //            break;
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Sehv cavab daxil etdiniz!");
            //            Console.WriteLine("Sohbet basladilsin? He/Yox");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mesaji daxil edin: ");
            //        string text = Console.ReadLine();

            //        if (text == "exit")
            //            break;

            //        Console.WriteLine(text);
            //    }
            //} while (startChat);
            #endregion



            #region Foreach loop

            //string[] citiesArray = new string[10];
            //citiesArray[0] = "Baki";
            //citiesArray[1] = "Gence";
            //citiesArray[2] = "Sumqayit";
            //citiesArray[3] = "Seki";
            //citiesArray[4] = "Kurdemir";
            //citiesArray[5] = "Naxcivan";
            //citiesArray[6] = "Quba";
            //citiesArray[7] = "Qusar";
            //citiesArray[8] = "Lenkeran";
            //citiesArray[9] = "Masalli";

            //foreach (var item in citiesArray)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Variable declarations inside/outside loop bodies

            string globalVariableName = "Orkhan";

            for (int i = 0; i < 5; i++)
            {
                globalVariableName = "Name can change here";
            }

            for (int i = 0; i < 5; i++)
            {
                string localVariableSurname = "Farajov";
            }

            //localVariableSurname = "Surname can't change here";
            Random rand = new Random();

            int a = rand.Next(1, 100);

            #endregion

            Console.ReadLine();
        }
    }
}
