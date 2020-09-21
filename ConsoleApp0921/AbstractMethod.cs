using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    abstract class Person
    {
        public abstract void Speak();//추상 메서드 정의
        
        public void Work()
        {
            Console.WriteLine("일을 합니다.");
        }
        public void Study()
        {
            Console.WriteLine("공부를 합니다.");
        }
    }
     class Employee : Person // abstractsms는 abstract로 받을수는 있지만 거의 드물다.
    {
        public override void Speak() //abstract는 꼭 override가 필요하다
        {
            Console.WriteLine("Employee가 일을 합니다.");
        }
    }
    class AbstractMethod
    {
        static void Main()
        {
            Person e1 = new Employee(); //abstract는 new가 불가능하다.
            e1.Speak();
           
        }
    }
}
