using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrinxRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var matrixInfo = Console.ReadLine().Trim().Split(' ');
            //var rows = int.Parse(matrixInfo[0]);
            //var cols = int.Parse(matrixInfo[1]);
            //var rotations = int.Parse(matrixInfo[2]);

            //var matrix = new List<List<int>>();

            //for (int row = 0; row < rows; row++)
            //{
            //    matrix.Add(Console.ReadLine().
            //        Trim().
            //        Split(' ').Select(x => int.Parse(x)).
            //        ToList());
            //}

            var matrix = new List<List<int>>()
            {
                 new List<int>{ 1,  2,  3,  4 },
                 new List<int>{ 5,  6,  7,  8 },
                 new List<int>{ 9, 10, 11, 12 },
                 new List<int>{13, 14, 15, 16 }
            };

            Result.MatrixRotation(matrix, 1);
        }
    }
}
