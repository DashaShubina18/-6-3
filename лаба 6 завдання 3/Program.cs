using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_6_завдання_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] array = new int[7, 5];
            GenerateMatrix(ref array);
            WriteMatrix(array);
            (int column,int min) = FindMin(array);
            Console.WriteLine("Мінімальний елемент дорівнює:" + min);
            Console.WriteLine("Номер стовпця,в якому знаходиться мінімальний елемент:" + column);

        }

        static void GenerateMatrix(ref int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 100);

                }

            }
        }
        static void WriteMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        static (int column,int min) FindMin(int[,] array)
        {
            int column = 0;
            int min = 101;
            for (int i=0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Math.Abs(array[i,j]) < min)
                    {
                        min = array[i,j];
                        column = j+1;
                    }
                }
            }
            return (column, min);

        }

          
    }
}
