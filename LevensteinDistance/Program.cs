using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevensteinDistance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string stringA = "колокол";
            string stringB = "молоко";

            int distance = LevensteinDistance(stringA, stringB);
        }

        private static int LevensteinDistance(string horizontal, string vertical)
        {
            int[,] array = new int[vertical.Length + 1, horizontal.Length + 1];

            for (int i = 0; i < vertical.Length; i++)
            {
                for (int j = 0; j < horizontal.Length; j++)
                {
                }
            }
        }
    }
}