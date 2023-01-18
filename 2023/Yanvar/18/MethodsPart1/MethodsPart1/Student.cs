using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    public class Student
    {
        /*
          Method necə yazılır?
          [access modifier] [return type] [method name] ( parameters ){
            method'un body hissesi
          }

          Access Modifiers:
          1. Public
          2. Private
          3. Protected
          4. Internal
          5. Internal Protected
         */

        public void HelloStudent()
        {
            Console.WriteLine("Salam telebe!");
        }

        private void ShowStudentInfo(string name, string surname)
        {
            Console.WriteLine("Telebe melumatlari: {0} {1}", name, surname);
        }

        public void ShowOrkhanInfo()
        {
            ShowStudentInfo("Orkhan", "Farajov");
        }
    }
}
