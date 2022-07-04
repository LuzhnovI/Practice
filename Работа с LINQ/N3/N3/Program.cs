using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    public struct Clients
    {
        public Clients(string _name, int _age, string _disease)
        {
            name = _name;
            age = _age;
            disease = _disease;
        }

        public string name { get; }
        public int age { get; }
        public string disease { get; }
        public override string ToString()
        {
           
                return $"Больной {name}, {age}, диагноз: {disease}.";

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Clients> clients = new List<Clients>() { 
                new Clients("Василич", 60, "Цирроз печени"), 
                new Clients("Кузьмич", 65, "Цирроз печени"), 
                new Clients("Жан Матьё", 18, "Воспаление хитрости"),
                new Clients("Армстронг", 34, "Воспаление мышц"),
                new Clients("Иван", 19, "Мозговая недостаточность"),
                new Clients("Пушкин", 37, "Перееизбыток железа"),
                new Clients("Гугол", 22, "Транзитный перегрев"),
                new Clients("Шариков", 39, "Мозговая недостаточность"),
                new Clients("Фифти", 22, "Перееизбыток железа"),
                new Clients("Райт", 35, "Мозговая недостаточность"),
            };
            while (true) 
            {
                Console.Write("1)Отсортировать всех больных по фио\n2)Отсортировать всех больных по возрасту\n3)Вывести больных с определенным заболеванием\n4)Выход\nВведите пункт:");
                switch (Console.ReadKey().KeyChar)
                    {
                    case '1':
                        Console.WriteLine();
                        foreach (Clients i in from c in clients orderby c.name select c)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        break;
                    case '2':
                        Console.WriteLine();
                        foreach (Clients i in from c in clients orderby c.age select c)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        break;
                    case '3':
                        Console.WriteLine();
                        Console.Write("Введите заболевание:");
                        string s = Console.ReadLine();
                        foreach (Clients i in from c in clients where c.disease==s select c)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine();
                        break;
                }
                
            }

            //foreach (Clients i in from b in bandits where b.arrest select b)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            //Console.WriteLine("После:");
            //foreach (Bandits i in from b in bandits where b.arrest & (b.reason != "Антиправительственное") select b)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            //Console.ReadKey();
        }
    }
}