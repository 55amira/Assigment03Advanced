using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringFunction
    {
        public static int GetCountOfUpperCaseChar(string word)
        {
            int Count = 0;
            if(!string.IsNullOrEmpty(word))
            {
                for(int i = 0; i < word.Length; i++)
                {
                    if(char.IsUpper(word[i]))
                    {  Count++; }   
                }
            }
            return Count;
        }
    }
}
