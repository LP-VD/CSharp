using System;
namespace Lessson3_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region 练习题1
            //将1到10000赋值给一个二维数组（100行，100列），并计算每一行的和，输出到控制台
            int[,] arr = new int[100, 100];
            int num = 1;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    arr[i, j] = num;
                    num++;
                }
            }

            //计算每一行的和，输出到控制台
            for (int i = 0; i < 100; i++)
            {
                int sum = 0;
                for (int j = 0; j < 100; j++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine($"第{i + 1}行的和为：{sum}");
            }
            #endregion

            #region 练习题2
            //将二维数组（4行4列）的右上半部分置零（元素随机1～100）
            int[,] arr2 = new int[4, 4];
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i <= 1 && j > 1)
                    {
                        arr2[i, j] = 0;
                    }
                    else
                    {
                        arr2[i, j] = rand.Next(1, 101);
                    }
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }
            #endregion

            #region 练习题3
            //求二维数组（3行3列）的对角线元素之和（元素随机1～100）
            int[,] arr3 = new int[3, 3];
            int diagonalSum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr3[i, j] = rand.Next(1, 11);
                    //对角线元素满足的条件
                    if (i == j || i + j == 2)
                    {
                        diagonalSum += arr3[i, j];
                    }
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(diagonalSum);
            #endregion

            #region 练习题4
            //求二维数组（5行5列）的最大值及其位置（元素随机1～500）
            int[,] arr4 = new int[5, 5];
            int maxI = 0;
            int maxJ = 0;
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    arr4[i, j] = rand.Next(1, 501);
                    Console.Write(arr4[i, j] + " ");
                    //找最大值
                    if (arr4[maxI, maxJ] < arr4[i, j])
                    {
                        maxI = i;
                        maxJ = j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"最大值为：{arr4[maxI, maxJ]}，位置为：({maxI},{maxJ})");
            #endregion

            #region 练习题5
            //给一个M*N的二维数组，数组元素的值为0或1
            //要求转换数组，将含有1的行和列全部变为1
            int[,] arr5 = new int[5, 5];
            bool[] hang = new bool[5];
            bool[] lie = new bool[5];
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    arr5[i, j] = rand.Next(0, 2);
                    if (arr5[i, j] == 1)
                    {
                        hang[i] = true;
                        lie[j] = true;
                    }
                    Console.Write(arr5[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("转换后：");
            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    if (hang[i] || lie[j])
                    {
                        arr5[i, j] = 1;
                    }
                    Console.Write(arr5[i, j] + " ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}