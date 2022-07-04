using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    public struct Bandits
    {
        public Bandits(string _name, bool _arrest, double _growth, double _weigth, string _nation, string _reason)
        {
            name = _name;
            arrest = _arrest;
            growth = _growth;
            weigth = _weigth;
            nation = _nation;
            reason = _reason;
        }

        public string name { get; }
        public bool arrest { get; }
        public double growth { get; }
        public double weigth { get; }
        public string nation { get; }
        public string reason { get; }
        public override string ToString()
        {
            if (arrest)
                return $"Заключённый {name}, {nation}, рост {growth}, вес {weigth}, по причине {reason}.";
            else
                return $"Разыскиваемый {name}, {nation}, рост {growth}, вес {weigth}, по причине {reason}."; ;

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Bandits> bandits = new List<Bandits>() { new Bandits("Василич", true, 189.9, 87.7, "европиоид", "Антиправительственное"), new Bandits("Кузьмич", false, 180.6, 84.1, "европиоид", "Антиправительсовенное"), new Bandits("Жан Матьё", true, 189.6, 80.0,"азиат", "Радикальная философия") };
            Console.WriteLine("До:");
            foreach (Bandits i in from b in bandits where b.arrest select b)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("После:");
            foreach (Bandits i in from b in bandits where b.arrest&(b.reason!="Антиправительственное") select b)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
        }
    }
}