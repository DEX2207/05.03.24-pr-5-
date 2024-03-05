using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24__pr_5_
{
    class Product:Catalog
    {
        public Product(string name, double price, DateTime create, DateTime expiratiopndate): base(name,price, create, expiratiopndate)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Название продукта: {Name}\nЦена: {Price}\nДата производства: {Create.ToString("d")}\nСрок годности: {Expirationdate.ToString("d")}");
            Expirationdate1();
        }
        public static Product Enter()
        {
            Console.Write("Введите название: ");
            string name=Console.ReadLine();
            Console.Write("Введите цену: ");
            double price=Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите дату производства: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime create=new DateTime(year, month, day);
            Console.Write("Введите срок годности: ");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            DateTime expiratiopndate = new DateTime(year, month, day);
            return new Product(name, price, create, expiratiopndate);
        }
    }
}
