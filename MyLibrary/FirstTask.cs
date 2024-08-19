using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    delegate void CountFirstSymbols(string Row);
    public class FirstTask
    {
        CountFirstSymbols SortA = delegate (string row)
        {
            char[] chars = row.ToCharArray();
            for (int j = 0; j < chars.Length; j++)
            {
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    if (chars[i] < chars[i + 1])
                    {
                        char tmp = chars[i];
                        chars[i] = chars[i + 1];
                        chars[i + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
            }
            Console.WriteLine("\n");

        };
        CountFirstSymbols SortL = (row) =>
        {
            char[] chars = row.ToCharArray();
            for (int j = 0; j < chars.Length; j++)
            {
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    if (chars[i] < chars[i + 1])
                    {
                        char tmp = chars[i];
                        chars[i] = chars[i + 1];
                        chars[i + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
            }
            Console.WriteLine("\n");
        };

        public void Anonimus()
        {
            Console.WriteLine("Введiть рядок: ");
            string Row = Console.ReadLine();
            Console.WriteLine("Вiдсортований рядок анонiмним-виразом: " );
            SortA(Row);
            
        }
        public void Lyambda()
        {
            Console.WriteLine("Введiть рядок: ");
            string Row = Console.ReadLine();
            Console.WriteLine("Вiдсортований рядок лямбда-виразом: ");
            SortL(Row);
            
        }
    }
}
