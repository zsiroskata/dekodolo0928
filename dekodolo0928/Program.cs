using System;
using System.Collections.Generic;
using System.IO;

namespace dekodolo0928
{
    class Program
    {
        static void Main(string[] args)
        {
            var karakter = new List<Karakter>();
            var sr = new StreamReader(
                path:@"..\..\..\dekodol.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while (!sr.EndOfStream)
            {
                char b = char.Parse(sr.ReadLine());
                bool[,] m = new bool[7, 4];

                for (int s = 0; s < 7; s++)
                {
                    string sor = sr.ReadLine();
                    for (int o = 0; o < sor.Length; o++)
                    {
                        m[s, o] = sor[o] == '1';
                    }
                }
                karakter.Add(new Karakter(b, m));
            }
            Console.WriteLine($"karakter szam {karakter.Count}");
            char input = ' ';
            bool res = false;
            do
            {
                Console.WriteLine("input: ");
                //input = char.Parse(Console.ReadLine());
                res = char.TryParse(Console.ReadLine(), out input);
            }while (!res || input < 65 || input > 90) ;

            //ascii table 
        }
    }
}
