using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05._03._24__pr_5_
{
    class Set
    {
        private string setname;
        private double price;
        List<string> set=new List<string>();

        public Set(string setname, List<string> set,double price) 
        {
            this.setname = setname;
            this.set = set;
            this.price = price;
        }

        public string Setname { get => setname; set => setname = value; }
        public double Price { get => price; set => price = value; }

        public void Print()
        {
            Console.WriteLine($"Название продукта: {Setname}\nЦена: {Price}\nПродукты: {set}");
        }
        public static Set Enter()
        {
            List<string> set = new List<string>();
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество продуктов: ");
            int quantity=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < quantity; i++) 
            {
                Console.WriteLine($"Введите {i+1} продукт: ");
                set[i]=Console.ReadLine();
            }
            return new Set(name, set, price);
        }
    }
}
