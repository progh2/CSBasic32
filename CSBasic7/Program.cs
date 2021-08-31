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
