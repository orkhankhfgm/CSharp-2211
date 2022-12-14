using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesPart_3_and_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            //(Boxing)

            //Implicit
            int valueType = 100; //Stack'da saxlanilir
            object referanceType = valueType;

            //Explicit
            object otherRefType = (object)valueType;

            //Unboxing
            int a = 100;
            object o = a;
            int unboxing = (int)o;

            //error example InvalidCastException
            int b = 100;
            object o1 = b;
            //int err = (byte)o1;
            #endregion



            #region Convert, Parse and TryParse
            string textNumber = "100";

            //with convert
            int convertToInt = Convert.ToInt32(textNumber);

            //with parse method
            int parseToInt = int.Parse(textNumber);

            //with tryParse method
            int integerValue;

            string notNumberString = "5Salam";
            bool badResult = int.TryParse(notNumberString, out integerValue); //0

            string numberString = "5";
            bool goodResult = int.TryParse(numberString, out integerValue); //5
            #endregion



            #region Task in Lesson 1
            /*
             1 bool tipində dəyişəniniz olacaq və true dəyərinə sahib olacaq.
             2. int tipində dəyişən yaradıb 1 dəyərini set edin.
             3. elə etməlisiniz ki, boolean dəyişəninizi necəsə konvertasiya edib int ə 0 dəyərini verəsiniz.
             (Convert, Parse və TryParse dan istifadə etməlisiniz.)
             */

            bool booleanVar = true;
            int resultOfTryParse = 1;

            string stringVar = Convert.ToString(booleanVar);
            bool parse = int.TryParse(stringVar, out resultOfTryParse);
            int result = Convert.ToInt32(parse);

            string nullString = null;

            int nullConvertResult = Convert.ToInt32(nullString); //default value
            //int nullParseResult = int.Parse(nullString); //xeta
            int nullOutVal = 2;
            bool tryToParseNull = int.TryParse(nullString, out nullOutVal); //default value


            string notIntString = "A";

            //int notIntConvertResult = Convert.ToInt32(notIntString); //xeta
            //int notIntParseResult = int.Parse(notIntString); //xeta
            int notIntOutVal = 2;
            bool tryToParseNotInt = int.TryParse(notIntString, out notIntOutVal); //default value
            #endregion



            #region Task in Lesson 2
            {
                /*
                 Task 1: İki dənə int tipində dəyişəniniz olacaq. Birinin dəyəri1, digərinin dəyəri 0 olacaq.
                         Sonra bu iki int tipindən başqa bool tipində 2 dəyişəniniz olacaq. Bu iki int tipində
                         olan dəyişəninizi digər iki bool tipində dəyişənə çevirəcəksiniz.
                */

                int falseVal = 0;
                int trueVal = 1;

                //bool falseBool = falseVal;
                //bool trueBool = trueVal;
                //bool trueBool = (bool)trueVal;
                bool trueBool = Convert.ToBoolean(trueVal);
                bool falseBool = Convert.ToBoolean(falseVal);

                /*
                    Task 2: Bir dənə DateTime tipində dəyişəniniz olsun və indiki zamanı götürsün. Sonra o dəyişəni
                            bir başqa object tipindəki dəyişənə mənimsədin. Yəni Boxing. Sonra DateTime tipində
                            3-cü bir dəyişən yaradın və 2-ci yaratdığınız object'in dəyərini 3-cü yaratdığınız
                            DateTime tipində olan dəyişənə verin.
                */

                DateTime now = DateTime.Now;
                object objDate = now;
                DateTime dateFromObject = Convert.ToDateTime(objDate);

                /*
                    Task 3: İki string tipində dəyişəndə True və False sözlərini saxlayın. Sonra bu string'ləri bool
                            tipində bir dəyişənə çevirin. Convert class'ından istifadə etmək OLMAZ!
                */
                string trueText = "True";
                bool trueFromText = bool.Parse(trueText);

                string falseText = "False";
                bool falseFromText = bool.Parse(falseText);
            }
            #endregion


            #region Constant
            {
                double pi = 3.14;
                //Bir ay kecdi
                pi = 5.20;

                const double piConst = 3.14;
                //piConst = 5.20; //xeta

                int no; //burada teyin etdim
                no = 100; //deyerini burda verdim

                decimal dec;
                dec = 45.6m;

                string name;
                name = "Orkhan";

                DateTime dt;
                dt = DateTime.Now;

                //const int aa; //deyer vermeden teyin etmek olmaz
                const int number = 500; //deyeri set olunmalidir
                                        //const int buildingNo = no; //const, ancaq const deyer qebul edir;
                const int buildingNo = number;
            }
            #endregion



            #region Var
            {
                int number = 1;
                string text = "Hello baby";
                decimal dec = 45.3m;
                double dob = 100.2d;
                DateTime dt = DateTime.Now;
                char ch = '2';
                long l = 89489489489489;
                short s = 10000;

                var numberVar = 1;
                var textVar = "Hello baby";
                var decVar = 45.3m;
                var dobVar = 100.2d;
                var dtVar = DateTime.Now;
                var chVar = '2';
                var lVar = 89489489489489;
                var sVar = 10000;

                //var i = 100;
                //i = "Salam"; //xeta

                var dbl = 45.5d;
                //dbl = true; //xeta

                var ddt = DateTime.Now;
                //ddt = '5'; //xeta

                //type inference
                //IL

                //var test = null;

                object objectVariable = 1;
                objectVariable = "Test";
                objectVariable = true;
                objectVariable = '$';
                objectVariable = DateTime.Now;

                int seeIntMethods = 5;
                string seeStringMethods = "Salam";
                object obj1 = seeIntMethods;
                object obj2 = seeStringMethods;

                //seeIntMethods.
                //seeStringMethods.
                //obj1.
                //obj2.

                int number1, number2, number3;
                string name, surname, fatherName, birthPlace;
                DateTime startDate, endDate;

                int no1 = 20, no2 = 40, no3 = 100;
                string firstname = "Orkhan", lastname = "Farajov", color = "White";

                //string firstname = "Orkhan";
                //string lastname = "Farajov";
                //string color = "White";
            }
            #endregion



            #region Operators
            {
                /*
                 1. Unary: a++, b--, !true
                 2. Binary: a + b, a > b, a = b;
                 3. Ternary: a > b ? "" : "";

                 Operator nədir? : +, -, *, !, !=
                 Operand nədir? : a, b, c (dəyişənlər və s.)

                 1. Arithmetic (hesablama)      ++, --, +, -, *, /, %
                 2. Logical (məntiqi)           !, ||, &&
                 3. Special (xüsusi)            sizeof, typeof, new, checked, unchecked, as, is
                 4. Assignment (mənimsəmə)      =, +=, -=, /=, *=, %=
                 5. Comparsion (qarşılaşdırma)  >, <, ==, !=, <=, >=
                 */

                decimal x = 100;
                decimal y = 5;
                decimal i = 0;

                //Arithmetic(hesablama)
                i = x + y;
                i = x - y;
                i--; //(i = i - 1) ilə eynidir
                i++; //(i = i + 1) ilə eynidir
                i = i - 1;
                i = i + 1;
                i -= 5; //(i bərabərdir, i çıx 5)
                i += 5; //(i bərabərdir, i topla 5)
                i = x--;
                i = y * 5;
                i = x / 5;
                i = x * y;
                i = x / y;
                i = x % y; //mod
                int m = 10 % 2;
                m = 11 % 2;
                string country = "Azerbaijan";
                string city = "Baku";
                string address = country + " " + city;

                //Logical(məntiqi)
                bool trueBool = true, falseBool = false, res;
                res = !trueBool;
                res = !falseBool;
                res = !falseBool || !trueBool;
                res = !falseBool && !trueBool;
                res = 5 == 5;

                //Assignment (mənimsəmə)
                int assign = 100;
                assign += 5; //(assign = assign + 5)
                assign -= 5; //(assign = assign - 5)
                assign /= 5; //(assign = assign / 5)
                assign *= 5; //(assign = assign * 5)
                assign %= 2; //(assign = assign % 2)
                string person = "Orkhan Farajov";
                person += " is developer";


                //Comparsion (qarşılaşdırma)
                int c = 100;
                int d = 5;
                string name1 = "Orkhan";
                string name2 = "John";

                bool compareRes = false;
                compareRes = c > d;
                compareRes = c < d;
                compareRes = c == d;
                compareRes = c != d;
                compareRes = c <= d;
                compareRes = c >= d;
                //compareRes = name1 >= name2;
                //compareRes = name1 == c; //string və int tipində operandlar qarşılaşdırıla bilməz
                compareRes = name1 == name2;
                compareRes = name1 != name2;
                compareRes = (10 / 2) == 5;
                compareRes = (10 / 2) != 5;



                //Special (xüsusi) sizeof, typeof, new, checked, unchecked, as, is
                //sizeof
                int sizeOf_sbyte = sizeof(sbyte); //1 byte
                int sizeOf_byte = sizeof(byte);   //1 byte
                int sizeOf_Int16 = sizeof(Int16); //2 byte
                int sizeOf_short = sizeof(short); //2 byte
                int sizeOf_Int32 = sizeof(Int32); //4 byte
                int sizeOf_int = sizeof(int);     //4 byte
                int sizeOf_Int64 = sizeof(Int64); //8 byte
                int sizeOf_long = sizeof(long);   //8 byte
                int sizeOf_ulong = sizeof(ulong); //8 byte
                int sizeOf_uint = sizeof(uint);   //4 byte
                int sizeOf_bool = sizeof(bool);   //1 byte
                //int sizeOf_String = sizeof(string);
                
                //typeof
                Type type1 = typeof(int);
                Type type2 = typeof(Int32);
                bool compareIntAndInt32 = type1 == type2;

                Type type3 = typeof(int);
                Type type4 = typeof(bool);
                bool compareIntAndBool = type3 == type4;

                //new
                DateTime dt = new DateTime();

                //is
                int otherInt = 25;
                bool isOtherInt_String = otherInt is string; //false
                bool isOtherInt_Int = otherInt is int; //true
                bool isOtherInt_Int32 = otherInt is Int32; //true
                bool isOtherInt_Int64 = otherInt is Int64; //false

                //as
                object objectName = "Orkhan";
                object objectNum = 5;
                string sName = objectName as string;
                string sText = objectNum as string;
                //int? aaa = sName as int?; //xeta

                //10 * 20 / 5
                float u = 10 + 20 * 5; //110
                float u1 = (10 + 20) * 2; //60
            }
            #endregion
        }
    }
}
