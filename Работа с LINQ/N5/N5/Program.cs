using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    public struct Meat
    {
        public Meat(string _name, int _done, int _expire)
        {
            name = _name;
            done = _done;
            expire = _expire;
        }

        public string name { get; }
        public int done { get; }
        public int expire { get; }
        public override string ToString()
        {

            return $"Тушонка \"{name}\" {done} года. Не съедобна в {done+expire}.";

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Meat> meat = new List<Meat>() {
                new Meat("Василич", 1975, 5),
                new Meat("Кузьмич", 1976, 4),
                new Meat("Жан Матьё", 2021, 3000),
                new Meat("Армстронг", 2000, 50),
                new Meat("Иван", 19, 140),
                new Meat("Пушкин", 1837, 300),
                new Meat("Гугол", 2221, 1),
                new Meat("Шариков", 1899, 1),
                new Meat("Фифти", 2000, 50),
                new Meat("Райт", 2000, 12),
            };
            Console.WriteLine("Не просрочено:");
            foreach (Meat i in from m in meat where m.done+m.expire>=DateTime.Now.Year select m)
            {
                Console.WriteLine(i.ToString());
            }
           
            Console.ReadKey();
        }
    }
}