using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._24__pr_5_
{
    internal class Enter
    {
        public static void Сhoice()
        {
            bool a = true;
            List<Catalog> list = new List<Catalog>();
            List<Set> sets = new List<Set>();
            while (a == true)
            {
                Console.WriteLine("1.Заполнение базы данных\n2.Вывод базы\n3.Выход");
                char number = Convert.ToChar(Console.ReadLine());
                switch (number)
                {
                    case '1':
                        Console.Write("Введите тип товара: ");
                        string type = Console.ReadLine();
                        switch (type)
                        {
                            case "Продукт":
                                list.Add(Product.Enter());
                                break;
                            case "Партия":
                                list.Add(Part.Enter());
                                break;

                            case "Комплект":
                                Set.Enter();
                                break;
                            default:
                                Console.WriteLine("Неизвестный тип");
                                return;
                        }
                        break;
                    case '2':
                        foreach (var elem in list)
                        {
                            elem.Print();
                        }
                        for(int i = 0; i < sets.Count; i++)
                        {
                            sets[i].Print();
                        }
                        break;
                    case '3':
                        a= false;
                        break;
                }
            }
        }
    }
}
