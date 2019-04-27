using System;
using System.Collections.Generic;
using static System.Console;

namespace ExpMethods {
    class Program {
        static void Main() {
            Write("Enter the number:  ");
            var i = "36";
            if (int.TryParse(i, out int result)) {
                WriteLine((result.IsEven()) ? "This number is even" : "This number is odd");
            } else {
                WriteLine("This is not number");
            }
            int h = 182;
            WriteLine((h.IsDividedBy(7)) ? "This number divided on 7" : "This number NOT divided on 7");
            WriteLine((172.IsDividedBy(7)) ? "This number divided on 7" : "This number NOT divided on 7");
            WriteLine((49.IsDividedBy(7)) ? "This number divided on 7" : "This number NOT divided on 7");

            var roads = new List<Road>();
            for (int j = 0; j < 10; j++) {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }
            Console.WriteLine(roads.ConvertToString());
            ReadKey();
        }
    }
}
