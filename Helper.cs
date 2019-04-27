using System;
using System.Collections;

namespace ExpMethods {
    static class Helper {
        public static bool IsEven(this int i) => i % 2 == 0;
        public static bool IsDividedBy(this int i, int j) => i % j == 0;
        public static string ConvertToString(this IEnumerable collection){
            var result = "";
            foreach(var item in collection) {
                result += $"|{item}|\n";
            }
            return result;
        }


        public static Road CreateRandomRoad(this Road road, int min, int max) {
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            road.Number = "M" + rnd.Next(1, 100);
            road.Lenght = rnd.Next(min, max);
            return road;
        }
    }
}
