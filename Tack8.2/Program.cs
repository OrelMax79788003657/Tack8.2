using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tack8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            StreamWriter sw = new StreamWriter("text.txt", false);

            int[] values = new int[10];

            for (int i = 0; i < 10; i++)
            {
                values[i] = r.Next(10);
                sw.WriteLine(values[i]);
            }
            sw.Close();

            StreamReader sr = new StreamReader("text.txt");
            int summ = 0;

            for (int i = 0; i <= 10; i++)
            {
                summ += Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();


            Console.WriteLine(summ);
            Console.ReadKey();
        }
    }
}
