using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello ");
            //Console.Write("World");

            //Console.WriteLine("Hello World");

            //Console.Write("test");

            //Console.Read();

            ///*
            // System - namespace adı
            // Console - System namespace'inin içində bir class adı
            // Write - Console class'ının içindəki bir method'un (funksiyanın) adı
            // */



            #region Task in Lesson 1
            /*
             Task: Ekrana "salam xoş gəlmisiniz!" yazdırın və bir sətir altında da "Adınızı daxil edin:" yazısı olsun.
             */
            //Console.WriteLine("Salam xos gelmisiniz!");
            //Console.WriteLine("Adinizi daxil edin: ");
            //Console.ReadLine();
            #endregion

            #region Read user data
            //var read = Console.Read();
            //var readKey = Console.ReadKey();
            //var test = Console.ReadLine();

            //Console.WriteLine("Xos gelmisiniz!");
            //Console.WriteLine("Adiniz nedir?");
            //var nameOfUser = Console.ReadLine();

            //var welcomeMsg = "Xos gelmisiniz!";
            //Console.WriteLine(welcomeMsg);

            //var whatIsYourName = "Adiniz nedir?";
            //Console.WriteLine(whatIsYourName);

            //Console.ReadLine();
            #endregion

            #region What is breakpoint?
            //Console.WriteLine("Top 1");
            //Console.WriteLine("Top 2");
            //Console.WriteLine("Top 3");
            //Console.WriteLine("Top 4");
            //Console.WriteLine("Top 5");
            //Console.WriteLine("Top 6");
            //Console.WriteLine("Top 7");
            //Console.WriteLine("Top 8");
            //Console.WriteLine("Top 9");
            //Console.WriteLine("Top 10");

            /*
             Breakpoint atdıqdan sonra, yəni debug edən zaman:
              - F10'a basdıqda olduğunuz sətirdən sonrakı ilk kod olan sətirə aparır.
              - F5'ə basdıqdan sonra olduğunuz sətirdən sonrakı bütün kodları oxuyub icra edir.
              - Kodu bir və ya bir neçə statement geriyə qaytarmaq üçün soldakı sarı oxu çəkmək lazımdır. Bu həmin kodu təkrar icra edir.
             */
            #endregion

            #region Task in Lesson 2
            /*
             red'in dəyəri qirmizi,
             car'ın dəyəri avtomobil,
             expensive'in dəyəri bahali,
             phone'un dəyəri telefon.
             Bu 4 dəyişəndən istifadə edib ekrana "qirmizi avtomobil" və növbəti sətirdə "bahali telefon" yazdırın.
             Ancaq elə edin ki, sözlər bir-birinə bitişik olmasın arasında boşluq olsun.
             */
            //var red = "qirmizi";
            //var car = "avtomobil";
            //var expensive = "bahali";
            //var phone = "telefon";

            //Console.Write(red);
            //Console.Write(car);
            //Console.WriteLine();
            //Console.Write(expensive);
            //Console.Write(phone);

            //Console.WriteLine(red + " " + car);
            //Console.WriteLine(expensive + " " + phone);
            #endregion

            #region Comment and Region
            //Single line comment

            /*
             This is
             multi line
             comment
             */
            #endregion

            #region Variables
            //typeOfVariable nameOfVariable = valueOfVariable


            string person = "Orkhan Farajov";
            Console.WriteLine(person);

            string anotherPerson;
            anotherPerson = "Orkhan Farajov";
            Console.WriteLine(anotherPerson);



            string name = "Elcin";
            Console.WriteLine(name);

            name = "Ferhad";
            Console.WriteLine(name);
            #endregion




            #region Naming Convention
            /*
             Nümunə dəyişən adları:
             _nameSurname (private field'lar üçün istifadə olunur)
             nameSurname
             anotherPerson
             nameSurname1
             anotherFatherName
             redCarName
             city
             countryCode
             */

            string anotherFatherName = "Elsen";
            #endregion




            #region What is ram and how does it work?
            /*
             1. S-RAM - (Static Random Access Memory)
             2. D-RAM - (Dynamic Random Access Memory)
             3. SD RAM (SDR SD RAM) - (Synchronous Dynamic Random Access Memory)
             4. DDR SD RAM (Double Data Rate Synchronous Dynamic Random Access Memory)
             5. GDDR SD RAM (Graphics Double Data Rate Synchronous Dynamic Random Access Memory)

             What is Memory management
             */
            #endregion
        }
    }
}
