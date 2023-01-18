using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Method
            Console.WriteLine("Orxan");

            System.Console.WriteLine("Orxan");

            SayHello();

            Student studentInstance = new Student();
            studentInstance.HelloStudent();

            //studentInstance.ShowStudentInfo("Orxan", "Ferecov");
            
            #endregion


            #region Task in Lesson 1
            studentInstance.ShowOrkhanInfo();
            #endregion
        }

        static void SayHello()
        {
            Console.WriteLine("Salam");
        }
    }
}
