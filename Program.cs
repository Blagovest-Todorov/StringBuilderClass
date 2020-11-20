using System;
using System.Linq;
using System.Text;

namespace _04.substrings
{
    class Program
    {
        static void Main()
        {
            //string result = str1 +str2;
            //IS  equivalent as :
            string str1 = string.Empty; //string is immutable Type

            StringBuilder sb = new StringBuilder(); //mutable Type 
            sb.Append("Hello ");
            sb.Append("World!");
            sb.Append(" and Hello C#");
            string result = sb.ToString();
            Console.WriteLine(result);
            
        }
    }
}
