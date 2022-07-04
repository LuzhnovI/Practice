using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    public struct Bandits
    {
        public Bandits(string _name, bool _arrest, double _growth, double _weigth, string _nation)
        {
            name = _name;
            arrest = _arrest;
            growth = _growth;
            weigth = _weigth;
            nation = _nation;
        }

        public string name { get; }
        public bool arrest { get; }
        public double growth { get; }
        public double weigth { get; }
        public string nation { get; }
        public override string ToString()
        {
            if (arrest)
                return $"Заключённый {name}, {nation}, рост {growth}, вес {weigth}.";
            else
                return $"Разыскиваемый {name}, {nation}, рост {growth}, вес {weigth}."; ;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Bandits> bandits = new List<Bandits>() { new Bandits("Василич", true, 189.9, 87.7, "европиоид"), new Bandits("Кузьмич", false, 180.6, 84.1, "европиоид"), new Bandits("Жан Матьё", false, 180.6, 84.1, "азиат") };
            List<Bandits> free = 
            foreach (Bandits i in )
        }
    }
}
