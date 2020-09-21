using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Point
    {
        public int x = 3;
        public int y = 5;
    }
    class Swap3//Reference타입 Swap
    {
       static void swap(Point p1) 
        {
            int temp = p1.y;
            p1.y = p1.x;
            p1.x = temp;
        }
        static void Main()
        {
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 5;
            Console.WriteLine($"x={p1.x}, y={p1.y}"); //3,5
            //swap(p1);
            Point p2 = new Point();//DeepCopy(새로운 인스턴스를 만들어 값에 영향을 받지 않게하는 방법)
            p2.x = p1.x;
            p2.y = p1.y;
            //Point np=p1; -> 같은것
            swap(p2);
            Console.WriteLine($"x={p1.x}, y={p1.y}"); //5,3
        }
    }
}
