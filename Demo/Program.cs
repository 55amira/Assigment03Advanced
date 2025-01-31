using System;
using System.Threading.Channels;

namespace Demo
{
    public delegate int StringFuncDelegate(string s);
    //public delegate bool conditionFuncDelegate(int X);
    public delegate bool conditionFuncDelegate<T>(T X);
    internal class Program
    {
        public static void PrintArray<T>(T[] Arr)
        {
            foreach (T t in Arr)
            {
                Console.Write($"{t} ");
            }
        }
        //public static List<int> FindNumbers(List<int> list, conditionFuncDelegate reference)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (reference(list[i]))
        //            {
        //                result.Add(i);
        //            }
        //        }
        //    }
        //    return result;
        //}

        public static List<T> FindElement<T>(List<T> list, Func<T,bool> reference)
        {
            List<T> result = new List<T>();
            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (reference(list[i]))
                    {
                        result.Add(list[i]);
                    }
                }
            }
            return result;
        }


        //public static List<int> FindOodNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionFunction.CheckOodNumber(list[i]))
        //            {
        //                result.Add(i);
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (ConditionFunction.CheckOodNumber(list[i]))
        //            {
        //                result.Add(i);
        //            }
        //        }
        //    }
        //    return result;
        //}
        //public static List<int> FindOodNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>(); 
        //    if(list?.Count>0)
        //    {
        //        for(int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] %2 != 0)
        //            {
        //                result.Add(i);
        //            }
        //        }
        //    }
        //    return result;  
        //}

        //public static List<int> FindEvenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0)
        //            {
        //                result.Add(i);
        //            }
        //        }
        //    }
        //    return result;
        //}
        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            if(list?.Count > 0)
            {
                foreach (T t in list)
                { 
                Console.Write($"{t} ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //StringFuncDelegate X = StringFunction.GetCountOfUpperCaseChar;
            //StringFuncDelegate X =new StringFuncDelegate (StringFunction.GetCountOfUpperCaseChar);
            //int Count = X.Invoke("Hello World");
            // int Count = X("Hello World");
            // Console.WriteLine(Count);

            //int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };
            //
            //PrintArray(Numbers);

            //SortFuncDeledate X = SortingCondition.CompareGeter;

            //SortFuncDeledate X = SortingCondition.CompareLesser;
            //
            //SortingAlgorithms.BubbleSort(Numbers,X);
            //SortingAlgorithms.BubbleSortAscending(Numbers);
            //Console.WriteLine(  );
            //PrintArray(Numbers);

            // string[] Names = { "Ahmed", "Ali", "Mona", "Mohamed" };
            // PrintArray(Names);
            // SortingAlgorithms.BubbleSort(Names, SortingCondition.CompareGeter);
            // Console.WriteLine( );
            // PrintArray(Names);

            Console.WriteLine();
            //List<int> Numbers = Enumerable.Range(1,100).ToList();
            //List<int> OOdNumber=FindOodNumbers(Numbers);
            //List<int> EnenNumber = FindEvenNumbers(Numbers);
            //List<int> OOdNumber = FindElement(Numbers,ConditionFunction.CheckOodNumber);
            //List<int> EvenNumber = FindElement(Numbers, ConditionFunction.CheckEvenNumber);
            //PrintList(EvenNumber);

            //List<string> Nemes = new List<string>() { "Ahmed", "Ali", "Mona", "Mohamed" };
            //List<string> Result = FindElement(Nemes, ConditionFunction.CheckLengthQual4);
            //PrintList(Result);  

            Predicate<int> predicate = ConditionFunction.CheckEvenNumber;
            bool X =predicate(1);
            Console.WriteLine(X);

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            //Func<int,bool> func = delegate(int x) { return x%2 ==0; };
            //FindElement(list, func);
             FindElement(list, delegate (int x) { return x % 2 == 0; });

            Func<int, bool> func =   x=>   x % 2 == 0;

            Fun01()();
        }

        public static Action Fun01()
        {
            Action action = () =>  Console.WriteLine("Hello"); 
            return action;
        }
    }
}
