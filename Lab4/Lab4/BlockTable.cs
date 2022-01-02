﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class BlockTable
    {
        public int[,] table = new int[100, 100];

        public void getTable(int columns, int rows, string pass)
        {
            CubeConGen cg = new CubeConGen();
            MaHash2 ma = new MaHash2();
            cg.generateSeq(ma.calculate(pass));
            int[] rr = new int[4];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    table[i, j] = i * columns + j;
                }
            }
            
            int prev = cg.generateElem(ma.calculate(pass));
            int counthash = Math.Abs(ma.calculate(pass) % 1000);
            for (int j = 0; j < counthash; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i % 2 == 0)
                    {
                        prev = cg.generateElem(prev);
                        rr[i] = prev % rows;
                    }
                    else 
                    {
                        prev = cg.generateElem(prev);
                        rr[i] = prev % columns;
                    }
                    Console.WriteLine(rr[i] + " " + prev);
                }
                int temp = table[rr[0], rr[1]];
                table[rr[0], rr[1]] = table[rr[2], rr[3]];
                table[rr[2], rr[3]] = temp;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
        public int encrypt()
        {
            return 0;
        }
    }
}