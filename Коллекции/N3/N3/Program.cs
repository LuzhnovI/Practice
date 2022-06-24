using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace N3
{
    class Program
    {
        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        static void Main(string[] args)
        {
            DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_CLOSE, MF_BYCOMMAND);
            List<int> l = new List<int>();
            Console.WriteLine("Команда sum выводит сумму всех веденных чисел.\nВыход из программы происходит с помощью команды exit.");
            for(int i=1; ; i++)
            {
                Console.Write($"Введите {i} число: ");
                string str = Console.ReadLine();
                switch (str)
                    {
                    case "exit":
                        return;
                    case "sum":
                        Console.WriteLine($"Сумма чисел: {l.Sum()}.");
                        Console.ReadKey();
                        return;
                    default:
                        try
                        {
                            l.Add(Convert.ToInt32(str));
                        }
                        catch 
                        {
                            i--;
                        }
                        break;

                }
                
                
            }
        }
    }
}
