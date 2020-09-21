using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Returns //return을 두개이상 받고 싶을때
    {
        static int Divide(int a,int b,ref int mod)//return을 2개받고 싶을때 ref나 out를 사용해서 2가지 받을수 있다
        {
            mod = a % b;
            return a / b;
        }
        static void Main()
        {
            int x = 10;
            int y = 4;
            int mod = 0;
            int result = Divide(x, y, ref mod);           
            Console.WriteLine($"몫:{result} 나머지:{mod}");

        }
    }
}
