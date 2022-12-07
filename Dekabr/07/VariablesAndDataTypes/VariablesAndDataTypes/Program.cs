using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes //Qite
{
    class Program //Olke
    {
        public static string Country { get; set; } = "Azerbaijan";

        static void Main(string[] args) //seher
        {
            /*
             Homework 3:
             int, bool, char, string və long tipində dəyişənlər yaradıb onlara dəyər verirsiniz. Sonra elə bir dəyişən yaratmalısınız ki, bütün bu dəyişənləri
             ona dəyər olaraq mənimsədə biləsiniz.
             */
            int a = 5;
            bool b = true;
            char c = 'C';
            string d = "Salam";
            long e = 999999999;

            object f = a;
            f = b;
            f = c;
            f = d;
            f = e;

            #region Assign one to another
            string orkhan = "Orkhan Farajov";
            string john = "John Farajov";

            orkhan = john;
            john = orkhan;

            orkhan = "hello";
            john = "hi";

            int fiveHundred = 500;
            int fiveHundredCopied = fiveHundred;

            bool isWinterCold = true;
            bool isSummerWarm = isWinterCold;
            isWinterCold = false;

            int five = 5;
            int fiveCopied = five;

            char p = 'p';
            char pCopied = p;
            #endregion

            #region Task in Lesson 5
            //20 dekabr 2020

            DateTime _1 = DateTime.Now;
            DateTime _2 = new DateTime(2020, 12, 20);
            #endregion


            #region Default values of data types
            //referance-types
            string defaultString;
            object defaultObject;
            Student defaultStudentClass;

            //value-types
            char defaultChar;
            byte defaultByte;
            short defaultShort;
            int defaultInt;
            long defaultLong;
            double defaultDouble;
            decimal defaultDecimal;
            float defaultFloat;
            bool defaultBool;
            DateTime defaultDateTime; //01.01.0001
            #endregion

            #region Local vs Global Variables
            Console.WriteLine(Country);

            ShowCountry();

            int myLocalVariable = 5;
            Console.WriteLine(myLocalVariable);



            int globalVar = 0;

            {
                int localVar1 = 555;
                globalVar += localVar1;
            }

            {
                int localVar2 = 45;
                globalVar += localVar2;
            }

            {
                int localVar3 = 50;
                globalVar += localVar3;
            }

            Console.WriteLine(globalVar);



            //Level 5 - Bütün stkoplara görə global və əl çatan (Main skopu daxilində)
            int level5 = 500;

            //level4 -= 100; //level4 does not exist
            //level3 -= 100; //level3 does not exist
            //level2 -= 100; //level2 does not exist
            //level1 -= 100; //level1 does not exist

            {
                //Level 4 - Alt skoplara görə global, üst skoplara görə local
                int level4 = 400;

                level5 -= 100;
                //level3 -= 100; //level3 does not exist
                //level2 -= 100; //level2 does not exist
                //level1 -= 100; //level1 does not exist

                {
                    //Level 3 - Alt skoplara görə global, üst skoplara görə local
                    int level3 = 300;

                    level5 -= 100;
                    level4 -= 100;
                    //level2 -= 100; //level2 does not exist
                    //level1 -= 100; //level1 does not exist

                    {
                        //Level 2 - Alt skoplara görə global, üst skoplara görə local
                        int level2 = 200;

                        level5 -= 100;
                        level4 -= 100;
                        level3 -= 100;
                        //level1 -= 100; //level1 does not exist

                        {
                            //Level 1 - tamamilə local dəyişən
                            int level1 = 100;

                            level5 -= 100;
                            level4 -= 100;
                            level3 -= 100;
                            level2 -= 100;
                        }
                    }
                }
            }

            int globalAge;

            {
                int localAge = 27;
                globalAge = localAge;
            }

            {
                Student localStudent = new Student();
                localStudent.Age = globalAge;

                Console.WriteLine(localStudent.Age);
            }

            #endregion
        }

        public static void ShowCountry()
        {
            Console.WriteLine(Country);
        }
    }
}
