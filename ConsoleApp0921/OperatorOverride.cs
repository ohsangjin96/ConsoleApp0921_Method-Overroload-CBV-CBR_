using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Time
    {
        int hours;
        int minutes;

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
            Examine();
        }
        public Time(int minutes) : this(0, minutes) { }

        private void Examine()
        {
            if (hours < 0 || minutes < 0)
            {
                Console.WriteLine("올바르지 않은 입력값입니다.");
                return;
            }
            hours = hours + (minutes / 60);
            minutes = minutes % 60;
        }

        public override string ToString()
        {
            return ($"{this.hours}:{this.minutes}");
        }
        #region as를 이용한 오버라이딩
        //public override bool Equals(object obj)
        //{

        //    Time T1 = obj as Time;
        //    if (T1 == null)
        //    {
        //        return false;
        //    }
        //    return T1 == obj;
        //}
        #endregion
        public override bool Equals(object obj)
        {
            return obj is Time time &&
                   hours == time.hours &&
                   minutes == time.minutes;
        }
        private int TotalMinutes()
        {
            return hours * 60 + minutes;
        }
        public static Time operator +(Time T1,Time T2)//연산자 오버로드에 static과 operator+은 필수로 들어간다(이항연산자)
        {
            return new Time(T1.TotalMinutes()+T2.TotalMinutes());
        }
        public static Time operator ++(Time T1)//T1=T1+1(단항연산자)
        { 
            return new Time(T1.TotalMinutes() + 1);
        }
        public static bool operator >(Time T1,Time T2)//비교연산자(크다를 정의할려면 작다도 정의해야한다)
        {
            return T1.TotalMinutes() > T2.TotalMinutes();            
        }
        public static bool operator <(Time T1, Time T2)
        {
            return T1.TotalMinutes() < T2.TotalMinutes();
        }
       
    }
    class OperatorOverride
    {
        static void Main(string[] args)
        {
            Time T1 = new Time(1, 40);
            Console.WriteLine(T1.ToString());

            Time T2 = new Time(1,50);
            Console.WriteLine(Equals(T1, T2));

            Time T3 = T1 + T2;
            Console.WriteLine(T3);

            T1++;
            Console.WriteLine(T1);

            Console.WriteLine(T1>T2);
        }
    }
}
