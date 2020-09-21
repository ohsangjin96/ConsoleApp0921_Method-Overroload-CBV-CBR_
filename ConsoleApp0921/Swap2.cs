using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Swap2//문자열 스왑
    {
        static void ChangeWord(string arg)// Call By Value
        {
            arg = "World";
        }
        static void ChangeWord(ref string arg)//Call By Reference
        {
            arg = "World";
        }
        static void Main()
        {
            string str = "Hello";
            ChangeWord(str);
            Console.WriteLine(str);

            ChangeWord(ref str);
            Console.WriteLine(str);
        }

    }
}
