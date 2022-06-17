using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store m = new Store(new Article[] { new Article("Бубенцы", "Jingle", 99.99), new Article("Чекушки", "Петрович Далеко", 9.99), new Article("Фомка", "Всё для Фома", 1.99), new Article("Кирпич", "Кто-кто?", 10000.09) });
            while (true)
            {
                Console.WriteLine("Выберете действие:");
                Console.WriteLine("1 -- Выведение всего списка товаров.");
                Console.WriteLine("2 -- Поиск по номеру.");
                Console.WriteLine("3 -- Поиск по названию.");
                Console.WriteLine("4 -- Выход.");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.WriteLine();
                        string name = "";
                        string store = "";
                        double price = -1;
                        for (int i = 0; ; i++)
                        {
                            try
                            {
                                m.ReturnArticle(i, ref name, ref store, ref price);
                                Console.WriteLine("Название: {0}; Магазин: {1}; Цена: {2}.", name, store, price);
                            }
                            catch
                            {
                                break;
                            }
                        }
                        break;
                    //    case '2':
                    //        Console.WriteLine();
                    //        m.Full();
                    //        break;
                    //    case '3':
                    //        Console.WriteLine();
                    //m.Show();
                    //break;
                    //    case '4':
                    //        Environment.Exit('1');
                    //        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
            }
        }

        class Article
        {
            public Article(string name, string store, double price)
            {
                name_ = name;
                store_ = store;
                price_ = price;
            }
            private string name_;
            private string store_;
            private double price_;
            public string Name { get { return name_; } }
            public string Store { get { return store_; } }
            public double Price { get { return price_; } }

        }

        class Store
        {
            private Article[] m_;
            public Store(Article[] m)
            {
                m_ = m;
            }
            public void ReturnArticle(int ind, ref string name, ref string store, ref double price)
            {
                name = m_[ind].Name;
                store = m_[ind].Store;
                price = m_[ind].Price;
            }
            public int SearchForName(string name)
            {
                int ind = -1;
                foreach (Article ar in m_)
                {
                    if (ar.Name == name)
                    {
                        ind = Array.IndexOf(m_, ar);
                        break;
                    }

                }

                return ind;
            }
        }
    }
}
