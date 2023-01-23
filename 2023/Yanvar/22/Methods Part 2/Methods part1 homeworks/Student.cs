using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_part1_homeworks
{
    public class Student
    {
        /*
        Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
        Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
        Bunun üçün Method Overloading mövzusu araşdırılmalıdır. CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
        tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq.
        */
        public void CalcAverage(string name, string surname, decimal p1, decimal p2, decimal p3 = 45)
        {
            Console.WriteLine("Telebe melumatlari: ");
            Console.WriteLine("Ad Soyad: {0} {1}", name, surname);

            //(birinci yazi qaydasi)
            decimal average = CalcAverage(p1, p2, p3);
            RateAverage(average);

            //(ikinci yazi qaydasi)
            //RateAverage(CalcAverage(p1, p2, p3));
        }

        private void RateAverage(decimal avrg)
        {
            if(avrg <= 45)
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kesildiniz!", avrg);
            else
                Console.WriteLine("Ortalama qiymet : {0} - Imtahandan kecdiniz!", avrg);
        }

        public decimal CalcAverage(decimal p1, decimal p2, decimal p3)
        {
            //(birinci yazi qaydasi)
            //decimal avrg = (p1 + p2 + p3) / 3;
            //return avrg;

            return (p1 + p2 + p3) / 3;
        }
    }
}
