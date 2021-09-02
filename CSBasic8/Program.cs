﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic8
{
    class Program
    {
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("리소스가 해제되었습니다.");
            }
        }
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return Price.CompareTo((obj as Product).Price);
            }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        static void Main(string[] args)
        {
            using (Dummy d = new Dummy())
            {
                Console.WriteLine("뭔가 했습니다.");
            }

            List<Product> list = new List<Product>()
            {
                new Product(){ Name = "고구마", Price=1500},
                new Product(){ Name = "사과", Price=2400},
                new Product(){ Name = "바나나", Price=1000},
                new Product(){ Name = "배", Price=3000},
                new Product(){ Name = "멜론", Price=15000},
            };
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
