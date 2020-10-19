using System;
using System.Collections.Generic;

namespace treinamento.problemas
{
    // Pegar a diferença da soma das diagonais X e Y de uma matriz quadrada
    public class problema07
    {
        public List<List<int>> arr;
        public List<List<int>> arr2; // <-- invalid
        public List<List<int>> arr3;
        public problema07()
        {
            arr = new List<List<int>>(){
                                            new List<int>() { 11, 2,  4  },
                                            new List<int>() {  4, 5,  6  },
                                            new List<int>() { 10, 8, -12 },
                                        };

            arr2 = new List<List<int>>(){
                                            new List<int>() { 11, 2 },
                                            new List<int>() {  4, 5 },
                                            new List<int>() { 10, 8 },
                                        };

            arr3 = new List<List<int>>(){
                                            new List<int>() { 11, 2 },
                                            new List<int>() {  4, 5 },
                                        };

        }


        public int? diagonalDifference(List<List<int>> arr)
        {
            if (!IsItSquareArray(arr)) // <-- se não for matriz quadrada
                return null;

            int numberColls = NumberColls(arr) - 1;
            int numberRows = numberColls;
            int currentRow = 0;
            int sumX = 0;
            int sumY = 0;
            int pontX = 1;
            int pontY = numberColls - 1;

            for (int i = 0; i < arr.Count; i++) // row
            {
                var a = 0;
                var b = 0;
                for (int j = 0; j < arr[i].Count; j++) // col
                {
                    if (i == 0 && j == 0)
                        sumX = sumX + arr[i][j];
                    if (i == 0 && j == numberRows)
                        sumY = sumY + arr[i][j];
                    if (i == numberRows && j == 0)
                        sumY = sumY + arr[i][j];
                    if (i == numberColls && j == numberRows)
                        sumX = sumX + arr[i][j];

                    if (currentRow > 0 && currentRow < numberRows)
                    {
                        if (j == pontX && a == 0)
                        {
                            sumX = sumX + arr[i][j];
                            pontX++;
                            a++;
                        }
                        if (j == pontY && b == 0)
                        {
                            sumY = sumY + arr[i][j];
                            pontY--;
                            b++;
                        }
                    }
                }
                currentRow++;
            }

            int difference = Math.Abs(sumX - sumY);

            return difference;
        }


        public bool IsItSquareArray(List<List<int>> arr) // <-- // é uma matriz quadrada?
        {
            int row = 0;
            int col = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                col++;
                for (int j = 0; j < arr[i].Count; j++)
                {
                    row++;
                }
            }

            float res = (float)row / col;

            if (res == col)
                return true;
            else
                return false;
        }

        public int NumberColls(List<List<int>> arr) // <-- // nr de colunas da matriz
        {
            int col = 0;

            for (int i = 0; i < arr.Count; i++)
                col++;

            return col;

        }
    }
}