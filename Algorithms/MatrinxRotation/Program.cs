using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrinxRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixInfo = Console.ReadLine().Trim().Split(' ');
            var rows = int.Parse(matrixInfo[0]);
            var cols = int.Parse(matrixInfo[1]);
            var rotations = int.Parse(matrixInfo[2]);
            var test = 5;

            var matrix = new List<List<int>>();

            for (int row = 0; row < rows; row++)
            {
                matrix.Add(Console.ReadLine().
                    Trim().
                    Split(' ').Select(x =>int.Parse(x)).
                    ToList());
            }


            Result.MatrixRotation(matrix, rotations);
        }
    }
}
