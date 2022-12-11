using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple form app
            //Console.WriteLine("Salam necəsən? Üü Şş Əə Öö Ğğ Çç Iı");

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Console.WriteLine("Salam, xoş gəlmisiniz!");

            //Console.WriteLine("Adınızı daxil edin: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Soyadınızı daxil edin: ");
            //string surname = Console.ReadLine();

            //Console.WriteLine("Doğulduğunuz ölkəni daxil edin: ");
            //string country = Console.ReadLine();

            //Console.WriteLine("Boyunuzu daxil edin daxil edin: ");
            //string height = Console.ReadLine();

            //Console.WriteLine("Çəkinizi daxil edin daxil edin: ");
            //string weight = Console.ReadLine();

            //Console.Clear();

            //Console.WriteLine("Ad: " + name);
            //Console.WriteLine("Soyad: " + surname);
            //Console.WriteLine("Ölkə: " + country);
            //Console.WriteLine("Boy: " + height);
            //Console.WriteLine("Çəki: " + weight);

            //Console.ReadLine();
            #endregion



            #region Task in Lesson 1
            ///*
            // Task description:
            // Kiçik bir anket app'ı hazırlayacaqsınız. İlk öncə istifadəçiyə Xoş gəldiniz! mesajı göstərin. Növbəti sətirdə adını soruşun. Adını daxil
            // etdikdən sonra ona necə müraciət edəcəyinizi soruşun. Məsələn adını Orxan, meraciət qaydasını da bəy olaraq yazdısa növbəti suallar belə
            // olacaq:
            // 1. Orxan bəy neçə yaşınız var?
            // 2. Orxan bəy hansı sahədə işləyirsiniz?
            // 3. Orxan bəy ən son nə zaman kitab oxumusunuz?
            // 4. Orxan bəy sevdiyiniz rəng hansıdır?
            // 5. Orxan bəy avtomobil idarə edə bilirsiniz?
            // 6. Orxan bəy gündə neçə saat yatırsınız?
            // 7. Orxan bəy TV kanallarını izləyirsiniz?

            //Əgər istifadəçi müraciət qaydası olaraq bəy/xanım daxil etməsə o zaman birbaşa Orxan neçə yaşınız var? deyə soruşun.
            //Axırıncı sualdan sonra "Anketə qatıldığınız üçün təşəkkür edirik!" yazsın.
            // */

            //Console.WriteLine("Xoş gəldiniz!");

            //Console.WriteLine("Adınızı daxil edin: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Sizə necə müraciət edə bilərik? (Bəy/Xanım/Boş keçə bilərsiniz)");
            //string fm = Console.ReadLine();

            //Console.WriteLine(name + " " + fm + " neçə yaşınız var?");
            //string age = Console.ReadLine();

            //Console.WriteLine(name + " " + fm + " hansı sahədə işləyirsiniz?");
            //string job = Console.ReadLine();

            //Console.WriteLine(name + " " + fm + " ən son nə zaman kitab oxumusunuz?");
            //string book = Console.ReadLine();

            //Console.WriteLine(name + " " + fm + " sevdiyiniz rəng hansıdır?");
            //string color = Console.ReadLine();

            //Console.WriteLine(name + " " + fm + " avtomobil idarə edə bilirsiniz?");
            //string drivingSkills = Console.ReadLine();

            //Console.WriteLine(name + " " + fm + " gündə neçə saat yatırsınız?");
            //string sleepTime = Console.ReadLine();

            //Console.WriteLine(name + " " + fm + " TV kanallarını izləyirsiniz?");
            //string tv = Console.ReadLine();

            #endregion


            #region Type Conversion
            /*
             -Implicit
             -Explicit
             -User-Defined
             -Helper class
             */
            #region Implicit Type Conversion
            ////Nümunə 1: byte to short
            //byte byteVal = byte.MaxValue; //255
            //short shortVal = short.MaxValue; //32767
            //short takeByteVal = byteVal; //(implicit type conversion)

            ////Nümunə 2: short to int
            //int takeShortValue = shortVal; //(implicit type conversion)

            ////Nümunə 3: byte to int
            //int takeBtVal = byteVal; //(implicit type conversion)

            ////Nümunə 4:
            //int i = 5000;
            //long l = i;

            //long l2 = 5000000;
            //float f = l2;

            //float f2 = 25.6F;
            //double d = f2;

            ////Ardıcıllıq: byte -> short -> int -> long -> float -> double
            #endregion


            #region Signed - Unsigned data types
            ////Unsigned data types:
            //byte us1 = byte.MinValue;     //8 bit  | 0 ilə 255
            //ushort us2 = ushort.MinValue; //16-bit | 0 ilə 65.535
            //uint us3 = uint.MinValue;     //32-bit | 0 ilə 4.294.967.295
            //ulong us4 = ulong.MinValue;   //64-bit | 0 ilə 18.446.744.073.709.551.615

            ////Signed data types:
            //sbyte s1 = sbyte.MinValue; //8 bit  | -128 ilə 127
            //short s2 = short.MinValue; //16-bit | -32.768 ilə 32.767
            //int s3 = int.MinValue;     //32-bit | -2,147,483,648 ilə 2,147,483,647
            //long s4 = long.MinValue;   //64-bit | -9.223.372.036.854.775.808 ilə 9.223.372.036.854.775.807

            ////unsigned ushort dəyər aralığı: 0 ilə 65.535
            ////signed short dəyər aralığı:    -32.768 ilə 32.767
            ////32.767 - 65.535 = -32.768
            #endregion


            #region Explicit Type Conversion
            ////Nümunələr:
            //int a = 20000;
            //short b = a;

            //double c = 785.22;
            ////float d = c;

            //short e = 10;
            ////ushort f = e;

            //float g = 15.5F;
            ////long h = g;

            //long i = 1000000000;
            ////int j = i;




            ////Nümunələr:
            //int a1 = 20000;
            //short b1 = (short)a1;

            //double c1 = 785.22;
            //float d1 = (float)c1;

            //short e1 = 10;
            //ushort f1= (ushort)e1;

            //float g1 = 15.5F;
            //long h1 = (long)g1;

            //long i1 = 1000000000;
            //int j1 = (int)i1;

            ////Yazılışı: hədəfTip a = (hədəfTip)QaynaqTip;
            #endregion


            #region Checked & Unchecked keywords
            //Casting without Checked keyword
            //long longVar = Convert.ToInt64(Console.ReadLine()); //9999999999999
            //int takeLongVar = (int)longVar;

            //short shortVar = Convert.ToInt16(Console.ReadLine()); //30000
            //byte takeShortVar = (byte)shortVar;

            //Casting with Checked keyword
            //checked
            //{
            //    long longVariable = Convert.ToInt64(Console.ReadLine()); //9999999999999
            //    int takelongVariable = (int)longVariable;
            //}

            //checked
            //{
            //    int money = Convert.ToInt32(Console.ReadLine()); //10000000=error / 10=success
            //    short takeInt = (short)money;

            //    unchecked
            //    {
            //        byte age = Convert.ToByte(Console.ReadLine()); //200
            //        sbyte takeByte = (sbyte)age;
            //    }
            //}
            #endregion


            #region Helper Class Conversions
            //string numberString = "50";
            //int number;

            ////Implicit Conversion nümunəsi:
            ////number = numberString;

            ////Explicit Conversion nümunəsi:
            ////number = (int)numberString;

            ////Helper Class Conversion nümunəsi:
            //number = Convert.ToInt32(numberString);

            ////Possible:
            //bool booleanVariable;
            //booleanVariable = Convert.ToBoolean(1); //true
            //booleanVariable = Convert.ToBoolean("true"); //true
            //booleanVariable = Convert.ToBoolean(null); //false

            //int integerVariable;
            //integerVariable = Convert.ToInt32("10"); //10
            //integerVariable = Convert.ToInt32(null); //0
            //integerVariable = Convert.ToInt32(true); //1
            //integerVariable = Convert.ToInt32(false); //0

            //string numString = "45";
            ////short stringToShort = numString; //xeta
            ////short stringToShort = (short)numString; //xeta
            //short stringToShortConvert = Convert.ToInt16(numString);

            ////int stringToInt = numString;
            ////int stringToIntCast = (int)numString;
            //int stringToIntConvert = Convert.ToInt32(numString);

            ////long stringToLong = numString;
            ////long stringToLongCast = (long)numString;
            //long stringToLongConvert = Convert.ToInt64(numString);


            ////Source data types
            //int intVariable = 10;
            //long longVariable = 99999999;
            //short shortVariable = 1000;
            //byte byteVariable = 150;
            //bool boolVariable = true;

            ////Destination data type
            //string getAnyValue;

            //getAnyValue = intVariable.ToString();
            //getAnyValue = longVariable.ToString();
            //getAnyValue = shortVariable.ToString();
            //getAnyValue = byteVariable.ToString();
            //getAnyValue = boolVariable.ToString();

            //bool _boolVariable = Convert.ToBoolean("false"); //false
            //byte _byteVariable = Convert.ToByte("10"); //unsigned
            //char _charVariable = Convert.ToChar("A");
            //DateTime _dateTimeVariable = Convert.ToDateTime("2022-12-12");
            //decimal _decimalVariable = Convert.ToDecimal("15.2");
            //double _doubleVariable = Convert.ToDouble("15.2");
            //short _shortVariable = Convert.ToInt16("-25000");
            //int _intVariable = Convert.ToInt32("1500000");
            //long _longVariable = Convert.ToInt64("99999999999999");
            //sbyte _sByteVariable = Convert.ToSByte("10"); //signed
            //ushort _ushortVariable = Convert.ToUInt16("10"); //unsigned
            //uint _uintVariable = Convert.ToUInt32("10"); //unsigned
            //ulong _ulongVariable = Convert.ToUInt64("10"); //unsigned

            //byte _byteVariable1 = Convert.ToByte(10); //unsigned
            //byte _byteVariable2 = Convert.ToByte(true); //unsigned
            //byte _byteVariable3 = Convert.ToByte(15.2F); //unsigned


            ////uint _uintNegative = Convert.ToUInt32("-10"); //error
            ////decimal _uintNegative = Convert.ToDecimal("Salam"); //error
            #endregion



            #region User-Defined Conversions
            Student student = new Student("Orkhan", "Farajov", 27);

            string strStudent = student;
            string strStudentCast = (Student)student;

            int stAge = student;
            int stAgeCast = (Student)student;

            bool stBool = student;
            bool stBoolCast = (Student)student;

            string strStudentToString = student.ToString();
            #endregion

            #endregion
        }
    }
}
