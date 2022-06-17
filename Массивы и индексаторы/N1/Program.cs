using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    class MyMatrix
    {
        private int[,] m_ = null;

        private int c_;
        private int r_;

        public int Cols
        {
            get { return c_; }
        }
        public int Rows
        {
            get { return r_; }
        }


        public MyMatrix(int cols, int rows)
        {
                c_ = cols;
                r_ = rows;
                m_ = new int[c_, r_];
        }

        public void Change(int x, int y)
        {
            int[,] temp = new int[x, y];
            for(int i=0; i<c_;i++)
                for(int j=0; j<r_;j++)
                try
                {
                        temp[i, j] = m_[i, j];
                }
                catch { }
            c_ = x;
            r_ = y;
            m_ = temp;
        }

        public void Full()
        {
            for (int i = 0; i < c_; i++)
                for (int j = 0; j < r_; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    m_[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }
        public void Show()
        {
            for (int i = 0; i < c_; i++)
            {
                Console.Write("( ");
                for (int j = 0; j < r_; j++)
                {
                    Console.Write(m_[i,j]+" ");
                }
                Console.WriteLine(")");
            }
        }


    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyMatrix m = new MyMatrix(0, 0);
            while (true)
            {
                Console.WriteLine("Выберете действие:");
                Console.WriteLine("1 -- Изменение размерности массива.");
                Console.WriteLine("2 -- Ввод массива.");
                Console.WriteLine("3 -- Вывод массива.");
                Console.WriteLine("4 -- Выход.");
                switch (Console.ReadKey().KeyChar)
                {
                    case '3':
                        Console.WriteLine();
                        m.Show();
                        break;
                    case '1':
                        Console.WriteLine();
                        Console.Write("Введите количество столбцов: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите количество строк: ");
                        m.Change(c, Convert.ToInt32(Console.ReadLine()));
                        break;
                    case '2':
                        Console.WriteLine();
                        m.Full();
                        break;
                    case '4':
                        Environment.Exit('1');
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
                
            }
            
        }
    }
}
