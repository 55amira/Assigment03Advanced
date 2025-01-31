using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ConditionFunction
    {
        public static bool CheckOodNumber(int X){ return X%2 !=0; }
        public static bool CheckEvenNumber(int X) { return X % 2 == 0; }
        public static bool CheckLengthGtr4(string X) { return X.Length > 4; }
        public static bool CheckLengthLes4(string X) { return X.Length < 4; }
        public static bool CheckLengthQual4(string X) { return X.Length == 4; }
    }
}
