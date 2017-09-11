using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];

            Array intArr = Array.CreateInstance(typeof(int), 10);
            // Array.Resize(ref arr1, 20);

            int[][] twoDim = new int[3][];
            twoDim[0] = new int[10];
            twoDim[1] = new int[3];
            twoDim[2] = new int[2];

            twoDim[0][0] = 42;
            twoDim[0][9] = 99;
            twoDim[2][1] = 23;

            int[,] jagged = new int[4, 8];
            jagged[0, 0] = 11;




        }
    }
}
