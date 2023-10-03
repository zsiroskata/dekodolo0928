﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dekodolo0928
{
    class Karakter
    {
        public char Betu { get; set; }
        public bool[,] Matrix { get; set; }
        public string Kirajzol()
        {
            string karakterKep = string.Empty;
            for (int s = 0; s < Matrix.GetLength(0); s++)
            {
                for (int o = 0; o < Matrix.GetLength(1); o++)
                {
                    karakterKep += Matrix[s, o] ? 'x' : ' ';
                }
                karakterKep += "\n";
            }
            return karakterKep;
        }

        public bool Felismer(Karakter felism)
        {
            for (int s = 0; s < Matrix.GetLength(0); s++)
            {
                for (int o = 0; o < Matrix.GetLength(1); o++)
                {
                    if (this.Matrix[s, o] != felism.Matrix[s, o]) return false;
                }
            }
            return true;
        }

        public Karakter(char betu, bool[,] matrix)
        {
            Betu = betu;
            Matrix = matrix;
        }
    }
}
