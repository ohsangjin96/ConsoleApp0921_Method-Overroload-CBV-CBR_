using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{

    class Swap//변수(값) swap
    {
        //static int x = 3; // 전역변수는 왠만해서는 쓰지 말아야한다.
        //static int y = 5;

        static void swap(ref int  a, ref int  b) // ref,out는 주소(call by reference)때 사용
        {
            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"x={a}, y={b}");
           
        }
       
        static void Main()//out은 값을 주지 않아도 되는것,ref는 값을 꼭 줘야하는것
        {
            int x = 3;
            int y = 5;
            Console.WriteLine($"x={x}, y={y}");

            swap(ref x,ref y);
            Console.WriteLine($"x={x}, y={y}");

            string str = "100";
            int.TryParse(str, out int a);
            
            Console.WriteLine(a);
        }
    }
}
