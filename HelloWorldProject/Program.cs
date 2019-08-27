//using System;

using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello C# boot camp World!");
            Console.WriteLine("At MAX Technical Training");
            int daysInBootcamp = 66;
            if (daysInBootcamp == 6)
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }

            
        string instructor = "";
        instructor = "Greg";
            Console.WriteLine(instructor);
            string lastname = "Doud";
            //how to concat( combine 2 strings)(+ only can be used to combine strings)
            Console.WriteLine(instructor + "" + lastname);
        }
    }
}
