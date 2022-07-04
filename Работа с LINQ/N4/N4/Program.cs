using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4
{
    public struct Gamers
    {
        public Gamers(string _name, int _lvl, int _srength)
        {
            name = _name;
            lvl = _lvl;
            srength = _srength;
        }

        public string name { get; }
        public int lvl { get; }
        public int srength { get; }
        public override string ToString()
        {

            return $"{name} {lvl}, сила: {srength}.";

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Gamers> gamers = new List<Gamers>() {
                new Gamers("Василич", 60, 5),
                new Gamers("Кузьмич", 65, 4),
                new Gamers("Жан Матьё", 18, 2147483647),
                new Gamers("Армстронг", 34, 5000),
                new Gamers("Иван", 19, 140),
                new Gamers("Пушкин", 37, 1837),
                new Gamers("Гугол", 22, 10100),
                new Gamers("Шариков", 39, -1),
                new Gamers("Фифти", 22, 50),
                new Gamers("Райт", 35, 12),
            };
            Console.WriteLine("Топ по уровню:");
            foreach (Gamers i in (from g in gamers orderby g.lvl descending select g).Take(3))
                        {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Топ по силе:");
            foreach (Gamers i in (from g in gamers orderby g.srength descending select g).Take(3))
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();

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