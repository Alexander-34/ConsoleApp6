using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            WriteLine("Введите целые положительные цисла A и B (A<B):");
            string str1 = ReadLine();
            string[] parts = str1.Split(' ');
            i = Convert.ToInt32(parts[0]);
            j = Convert.ToInt32(parts[1]);
            if (i>j)
            {
                int tmp = i;
                i = j;
                j = tmp;
            }
            int[][] arr1 = new int[j-i+1][];
            int m = i;
            for (int n=0; n <= j-i; n++)
            {                
                arr1[n] = new int[m];
                for (int n1 = 0; n1 < m; n1++)
                {
                    arr1[n][n1] = m;
                }
                m++;
            }
            m = i;
            for (int n = 0; n <= j - i; n++)
            {
              for (int n1 = 0; n1 < m; n1++)
                {
                    Write("{0, 3}", arr1[n][n1]);
                }
                WriteLine();
                m++;
            }            
        }
    }
}
