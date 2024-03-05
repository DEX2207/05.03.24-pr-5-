using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24__pr_5_
{
    abstract class Catalog
    {
        private string name;
        private double price;
        private DateTime create;
        private DateTime expirationdate;
        DateTime dateTime= DateTime.Now;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public DateTime Create { get => create; set => create = value; }
        public DateTime Expirationdate { get => expirationdate; set => expirationdate = value; }

        public Catalog(string name, double price,DateTime create,DateTime expiratiopndate) 
        {
            this.name = name;
            this.price = price;
            this.create = create;
            this.expirationdate = expiratiopndate;
        }
        public int Expiration()
        {
                return expirationdate.Subtract(dateTime).Days;
        }
        public void Expirationdate1()
        {
            if (Expiration() > 0)
            {
                Console.WriteLine($"До конца срока годности осталось:{Expiration()} дня");
            }
            else 
            {
                Console.WriteLine("Срок годности вышел");
            }
        }
        public abstract void Print();
    }
}
