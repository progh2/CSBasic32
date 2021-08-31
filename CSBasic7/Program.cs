using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
   class Products
    {

        private List<string> list = new List<string>();
        public Products()
        {
            list.Add("짜장면");
            list.Add("짬뽕");
            list.Add("탕수육");
            list.Add("볶음밥");
            list.Add("마파두부");
            list.Add("칠리새우");
        }
        public string this[int i]
        {
            get { return list[i]; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }

    class Program
    {
        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct Point
        {
            public int x;
            public int y;
            public string s;

            public Point(int x, int y)
            {
                this.x = x;
                //this.x = 0;
                this.y = y;
                this.s = null;
            }
        }

        static void NextPostion(int x, int y, int vx, int vy, 
            out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }

        class Wanted<T>
            //where T : Student
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }
        class Student
        {
            public override string ToString()
            {
                return "학생";
            }
        }

        static void Main(string[] args)
        {
            Point p = new Point(10, 20);
            Point p2 = p;
            p2.x = 100;
            p2.y = 200;
            Console.WriteLine(p.x + ", " + p.y);
            Console.WriteLine(p2.x + ", " + p2.y);

            PointClass pc = new PointClass(10, 20);
            PointClass pc2 = pc;
            pc2.x = 100;
            pc2.y = 200;
            Console.WriteLine(pc.x + ", " + pc.y);
            Console.WriteLine(pc2.x + ", " + pc2.y);

            Point point;
            point.x = 10;
            point.y = 10;

            Point point2 = new Point(10, 10);
            Point point3 = new Point();
            

            int x = 0;
            int y = 0;
            int vx = 1;
            int vy = 1;
            Console.WriteLine("현재좌표:" + x + "," + y);
            NextPostion(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음좌표:" + x + "," + y);

            Console.Write("숫자 입력:");
            int output = int.MinValue;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("변환성공:" + output);
            }
            else
            {
                Console.WriteLine("변환실패:" + output);
            }


            Products ps = new Products();
            Random rs = new Random();
            int i = rs.Next(0, 6);
            Console.WriteLine(ps[i]);


            Wanted<string> ws = new Wanted<string>("String");
            Wanted<int> wi = new Wanted<int>(42);
            Wanted<Student> wstu = new Wanted<Student>(new Student());
            Console.WriteLine(ws.Value);
            Console.WriteLine(wi.Value);
            Console.WriteLine(wstu.Value);
        }
    }
}
