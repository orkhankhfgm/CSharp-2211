using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Data Type
            //ededi hem string olaraq string de saxlamaq olur hem de int de
            string oneString = "1";
            int oneInteger = 1;

            string aString = "a";
            //int aInteger = "a"; //error


            /*
             1 byte = 8 bit
             Int16 tipi 16 bit'dir. - 16 bit / 8 bit = 2 byte
             Int32 tipi 32 bit'dir. - 32 bit / 8 bit = 4 byte
             Int64 tipi 64 bit'dir. - 64 bit / 8 bit = 8 byte
             */

            /*
             Value-Type data tipleri:
             bool
             byte
             char
             decimal
             double
             enum
             float
             int
             long
             sbyte
             short
             struct
             uint
             ulong
             ushort
             NOT: Default deyeri her zaman olur.

             Referance-Type data tipleri:
             String
             Arrays
             Class
             Delegate
             object
             NOT: Default deyeri her zaman NULL olur.
             */
            #endregion


            #region Practice with data types

            #region Boolean Type
            //Həcmi: 1 bit
            //Dəyər aralığı: true --- false
            //Tipi: Value-Type

            bool booleanVar = true;
            booleanVar = false;

            bool otherBooleanVar; //default deyerin false goturur
            otherBooleanVar = true;

            string falseString = bool.FalseString;
            string trueString = bool.TrueString;
            #endregion

            #region String Type
            //Həcmi: Hər bir xarakter üçün 1 byte
            //Tipi: Referance-Type

            string name_ = "Orkhan";
            Console.WriteLine(name_);

            string surname = "Farajov";
            Console.WriteLine(surname);

            string nameSurname = "teymur jafarov";

            //Bütün hərfləri böyük hərfə çevirir
            string upperNameSurname = nameSurname.ToUpper();

            //Bütün hərfləri kiçik hərfə çevirir
            string lowerNameSurname = nameSurname.ToLower();

            //0 indeksi daxil olmaqla, Teymur Jafarov stringinin 1-ci indexindən etibarən 5 simvol götürür
            string substring = nameSurname.Substring(1, 5);

            //t hərfi ilə başlayıb başlamamasını yoxlayır və true/false dəyər qaytarır
            bool startsWith = nameSurname.StartsWith("t");

            //v hərfi ilə bitib bitməməsini yoxlayır və true/false dəyər qaytarır
            bool endsWith = nameSurname.EndsWith("v");

            //stringin uzunluğunu qaytarır
            int length = nameSurname.Length;

            //0 daxil olmaqla indeksini qaytarır
            int indexOf = nameSurname.IndexOf("y");

            //dəyişənin dəyərinin Equals methoduna göndərilən parametrdəki dəyərlə eyni olub olmamasını yoxlayır
            bool equals = nameSurname.Equals("orkhan");
            bool equals1 = nameSurname.Equals("teymur jafarov");
            #endregion

            #region Short, Int, Long Types
            //Həcmi:
                //int16: 2 byte
                //int32: 4 byte
                //int64: 8 byte
            //ala bildiyi dəyər aralığı:
                //int16 bit üçün: -32.768 --- 32.767
                //int32 bit üçün: -2,147,483,648 --- 2,147,483,647
                //int64 bit üçün: -9,223,372,036,854,775,808 --- 9,223,372,036,854,775,807
            //tipi:
                //Value-Type

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;
            short shortValue = 18262;
            short shortValueNegative = -1562;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            int intValue = 2458745;
            int intValueNegative = -222666;

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            long longValue = 8489489489456456489;
            long longValueNegative = -8494864864864864156;

            string intToString = intValue.ToString();
            #endregion


            #region Task in lesson 1
            /*
             10 ve 20 reqemlerini deyisenlerde saxlayin ve ucuncu deyisende bu iki deyisenin toplamini elde edin.
             */
            int a_ = 10;
            int b_ = 20;
            int c_ = a_ + b_;
            #endregion

            #region Task in lesson 2
            /*
             aze ve tur "Turkiye"
             azeTur "Azerbaycan Turkiye"
             */
            string aze = "Azerbaijan";
            string tur = "Turkey";
            string azeTur = aze + " " + tur;
            #endregion


            #region Char Type
            //Həcmi: 2 byte
            //Tipi: Value-Type
            //character sozunun qisaldilmisidir
            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string e = "E";
            string f = "F";
            string g = "G";
            string h = "H";

            char charA = 'A';
            char charB = 'B';
            char charC = 'C';
            char charD = 'D';
            char charE = 'E';
            char charF = 'F';
            char charG = 'G';
            char charH = 'H';

            char symbol = '*';
            char whiteSpace = ' ';
            char question = '?';

            char toLower = char.ToLower(charA);
            char toUpper = char.ToUpper(charA);

            bool isLower = char.IsLower(toLower);
            bool isUpper = char.IsUpper(toUpper);

            bool isDigit = char.IsDigit(charA);
            bool isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            #endregion

            #region Byte Type
            //Həcmi: 1 byte
            //Aralığı: 0-255
            //Tipi: Value-Type

            byte byteVariable = 45;
            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            #endregion

            #region Double Type
            //Həcmi: 8 byte
            //Precision: 15-16 rəqəm
            //Aralığı: -1.7976931348623157E+308 --- 1.7976931348623157E+308
            //Tipi: Value-Type

            double doubleVar = 10.21561556156515654151514514515415615615;
            double doubleVar2 = 25;
            double doubleVar3 = 45.8d;

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;

            double nan = 0.0 / 0.0; //NaN = Not a Number
            double notNan = 5 / 2.5;
            bool resultOfNan = double.IsNaN(nan);
            bool resultOfNotNan = double.IsNaN(notNan);

            double infinity = 0.1 / 0.0;
            double notInfinity = 0.0 / 0.0;
            bool resultOfInfinity = double.IsInfinity(infinity);
            bool resultOfNotInfinity = double.IsInfinity(notInfinity);

            double epl = double.Epsilon;
            double epsilonValue = 4.94065645841247E-324;
            double one = 0.1;

            bool whichIsGreater = one > epsilonValue;
            #endregion

            #region Task in Lesson 3
            /*
             1. true
             2. 'A'
             3. 5 (RAM i nezere alin)
             4. "Salam"
             5. 18*9
             */
            bool _1 = true;
            char _2 = 'A';
            byte _3 = 5;
            string _4 = "Salam";
            double _5 = 999999999999999999;
            #endregion

            #region Decimal Type
            //Həcmi: 16 byte
            //Precision: 28-29 rəqəm
            //Aralığı: -79228162514264337593543950335 --- 79228162514264337593543950335
            //Tipi: Value-Type
            decimal decimalVar = 10.2m;

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;

            decimal minusOneValue = decimal.MinusOne;

            //byte decimalToByte = decimal.ToByte(10000000);
            //sbyte decimalToSByte = decimal.ToSByte(10000000);

            short decimalToShort = decimal.ToInt16(500);
            int decimalToInt = decimal.ToInt32(2225156);
            long decimalToLong = decimal.ToInt64(54564564554564515);
            #endregion


            #region Float Type
            //Həcmi: 4 byte / 32 bit
            //Precision: 7 rəqəm
            //Aralığı: -3.40282347E+38 --- 3.40282347E+38
            //Tipi: Value-Type
            float floatVar = 10.2F;

            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;
            #endregion

            #region DateTime Type
            //Həcmi: 8 byte
            //Aralığı: 1/1/0001 --- 12/31/9999
            //Tipi: Value-Type
            DateTime now = DateTime.Now; //(local saati qaytarir)
            DateTime utcNow = DateTime.UtcNow; //(UTC = Coordinated Universal Time)

            long ticks = now.Ticks;
            int millisecond = now.Millisecond;
            int second = now.Second;
            int minute = now.Minute;
            int hour = now.Hour;
            int day = now.Day;
            DayOfWeek dayOfWeek = now.DayOfWeek;
            int month = now.Month;
            int year = now.Year;
            TimeSpan timeOfDay = now.TimeOfDay;
            string shortDateString = now.ToShortDateString();
            string longDateString = now.ToLongDateString();
            string shortTimeString = now.ToShortTimeString();
            string longTimeString = now.ToLongTimeString();
            string timeFormat = now.ToString("MM/dd/yyyy HH:mm:ss");
            string timeFormat1 = now.ToString("MMMM dd");
            string timeFormat2 = now.ToString("dddd, dd MMMM yyyy");
            string timeFormat3 = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            string timeFormat4 = now.ToString("HH:ss");
            string timeFormat5 = now.ToString("H:mm");
            string timeFormat6 = now.ToString("ddd, dd MMM yyy HH:mm:ss");

            DateTime monthChanged = now.AddMonths(2);
            DateTime dayChanged = now.AddDays(2);
            DateTime hourChanged = now.AddHours(4);
            DateTime minuteChanged = now.AddMinutes(15);
            DateTime secondsChanged = now.AddSeconds(5);
            string changedTime = hourChanged.ToString("HH:mm");

            DateTime specificDate = new DateTime(1990, 12, 15);
            DateTime specificDateAndTime = new DateTime(1990, 12, 15, 10, 05, 59, 100 /*millisecond*/);

            /*
             specificDateAndTime məlumatları:
             İl: 1990
             Ay: 12 (dekabr)
             Gün: 15
             Saat: 10
             Dəqiqə: 05
             Saniyə: 59
             Millisaniyə: 100
             */
            #endregion

            #region Object Type
            //Həcmi: 4 byte
            //Aralığı: bütün C# obyektleri
            //Tipi: Referance-Type
            object stringVar = "My string";
            object integerVar = 55;
            object boolVar = true;
            object charVar = 'u';
            object dateTimeVar = new DateTime();

            Console.WriteLine(stringVar);
            Console.WriteLine(integerVar);
            Console.WriteLine(boolVar);
            Console.WriteLine(charVar);
            Console.WriteLine(dateTimeVar);
            #endregion

            #region Task In Lesson 4
            /*
             10.5
             20.5
             30.5
             */
            double _d = 10.5;
            decimal _m = 20.5m;
            float _f = 30.5f;
            #endregion
            #endregion
        }
    }
}
