using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;

        public override string ToString()
        {
            return id + ":" + name + "(" + price + "원)";
        }

        public Product(string name, int price)
        {
            //Product.counter = counter + 1;
            counter++;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
    }

    class Sample
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }


    class Program
    {
        int someModifier = 0;
        public int instanceVariable = 10;
        public int instanceMethod()
        {
            return 0;
        }

       class MyMath
        {
            public static int Abs(int input)
            {
                return (input < 0) ? -input : input;
                /*
                if(input < 0)
                {
                    return -input;
                }else
                {
                    return input;
                }*/
            }
            
            public static double Abs(double input)
            {
                return (input < 0) ? -input : input;
            }
            
            // Abs( long )
            public static long Abs(long input)
            {
                return (input < 0) ? -input : input;
            }

            // Abs( long )
            /* Method Signature가 같은 경우 오버로딩 불가!
            public static int Abs(long a2)
            {
                return 0;
            }
            */

        }

        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" });
            }

            // Method Signature 
            public int Sum(int min , int max )
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        class MethodExample
        {
            public int Power(int x)
            {
                return x * x;
            }

            public int Multi(int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출됨");
            }
        }
        


        static void Main(string[] args)
        {
            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(52, 273));
            Console.WriteLine(me.Multi(103, 32));
            me.Print();

            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            // 클래스 메서드에서는 인스턴스 변수/메서드 접근 불가!
            // 객체를 만들어 접근해야한다.
            //Console.WriteLine(instanceVariable);
            //instanceMethod();
            Program p = new Program();
            Console.WriteLine(p.instanceVariable);
            p.instanceMethod();

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(21474812312323));

            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Product productC = new Product("옥수수", 2000);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);
            Console.WriteLine(Product.counter + "개 생성되었습니다.");

            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);            
            Console.WriteLine("세 번째 위치");

        }
    }
}
