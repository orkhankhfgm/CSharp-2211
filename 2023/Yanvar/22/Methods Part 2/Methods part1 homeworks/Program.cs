using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_part1_homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
             Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
             Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
             tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq.
             */

            string name = string.Empty, surname = string.Empty;
            decimal p1 = 0, p2 = 0, p3 = 0;

            Console.WriteLine("Zehmet olmasa telebe melumatlarini daxil edin:");

            Console.WriteLine("Ad:");
            name = Console.ReadLine();

            Console.WriteLine("Soyad:");
            surname = Console.ReadLine();
            
            Console.WriteLine("Qiymet 1:");
            p1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qiymet 2:");
            p2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qiymet 3:");
            p3 = decimal.Parse(Console.ReadLine());

            Student student = new Student();
            student.CalcAverage(name, surname, p1, p2, p3);
            var test = student.CalcAverage(15, 20, 34);

            Console.ReadLine();
        }
    }
}
