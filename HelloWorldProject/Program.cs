//using System;

using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Yes");
            Console.WriteLine("Hello C# boot camp World!");
            Console.WriteLine("At MAX Technical Training");
            int daysInBootcamp = 66;
            if (daysInBootcamp == 6)
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }

            /*int i = 1;
             int j = 0;
             int k = i/j;
             */
            string instructor = "";
            instructor = "Greg";
            Console.WriteLine(instructor);
            string lastname = "Doud";
            //how to concat( combine 2 strings)(+ only can be used to combine strings)
            Console.WriteLine(instructor + "" + lastname);

            //looping with while
            // int[] means its an array of integars
            var ints = new int[] { 1, 2, 3, 4, 5 };
            var total = 0;
            var index = 0;
            while (index < 5)
            {
                total = total + (ints[index] * (ints)[index]);
                index = index + 1;

            }
            Console.WriteLine("Total is " + total);

            //Looping with for()

            total = 0;
            for(var idx = 0; idx < 5; idx++)
            {
                total = total + (ints[idx] * (ints)[idx]);

            }
            Console.WriteLine("Total is " + total);

            // assignment computer the average
            // use wild loop or for loop to add them up get the average and print it out on console line

            var scores = new int[] { 738, 609, 307, 959, 805, 689, 402, 972, 359, 140 };

            var tots = 0;
            for (var idx = 0; idx < 10; idx++)
            {

                tots = tots + (scores[index]);

            }
            var avg = tots / scores.Length;
            Console.WriteLine("Average Is " + avg);


            //assignment compute the average

            // looping with foreach() no index needed 
            var grandtotal = 0;
            foreach (var score in scores)
            {
                grandtotal += score;
            }
            Console.WriteLine(grandtotal);

            //fooating point numbers
            // get average with for each loop to get total
            var TotalDistance = 0.0;
            var distances = new double[] { 599, 356, 8.99, 7.47, 8.17, 6.78, 6.33};
            
            foreach (var distance in distances)
            {

                TotalDistance += distance;
                
            }
            var avgDistance = TotalDistance/ distances.Length;

            //arrays-fixed
            int[] students = new int[5];
            students[0] = 7;
            students[1] = 3;
            students[2] = 4;
            students[3] = 15;
            students[4] = 5;

            Console.WriteLine(students);
            //array of string

            string[] names = new string[7];
            names[0] = "Alex";
            names[1] = "Lidya";

        }
    }
}