using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24__pr_5_
{
    class Part: Catalog
    {
        private int quantity;

        public Part(string name, double price, int quantity, DateTime create, DateTime expiratiopndate) : base(name, price, create, expiratiopndate)
        {
            this.quantity = quantity;
        }
        public int Quantity { get => quantity; set => quantity = value; }

        public override void Print()
        {
            Console.WriteLine($"Название продукта: {Name}\nЦена: {Price}\n Количество: {Quantity}\nДата производства: {Create.ToString("d")}\nСрок годности: {Expirationdate.ToString("d")}");
            Expirationdate1();
        }
        public static Part Enter()
        {
            Console.Write("Введите название: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату производства: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime create = new DateTime(year, month, day);
            Console.Write("Введите срок годности: ");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            DateTime expiratiopndate = new DateTime(year, month, day);
            return new Part(name, price, quantity, create, expiratiopndate);
        }
    }
}
