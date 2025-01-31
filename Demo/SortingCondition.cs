using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SortingCondition
    {
        //public static bool CompareLesser(int X, int Y) {  return X < Y; }
        //public static bool CompareGeter (int X, int Y) { return X > Y; }

        public static bool CompareLesser(string X, string Y) { return X.Length < Y.Length; }
        public static bool CompareGeter(string X, string Y) { return X.Length > Y.Length; }

    }
}
