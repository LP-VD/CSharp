using System;
namespace Lesson06_递归
{
    class Program
    {
        #region 概念
        //递归就是自己调用自己的函数
        //递归函数必须有一个终止条件，否则会无限递归导致栈溢出

        //实例
        //用递归函数打印出0到10
        static void PrintNumbers(int n)
        {
            if (n < 0) //终止条件
            {
                return; //如果n小于0，直接返回
            }
            Console.WriteLine(n); //打印当前数字
            PrintNumbers(n - 1); //递归调用，打印下一个数字
        }
        #endregion

        #region 练习题一
        //传入一个值，求该值的阶乘，并返回如5! = 1*2*3*4*5 = 120
        static int Factorial(int n)
        {
            if (n <= 1) //终止条件
            {
                return 1; //如果n小于等于1，返回1
            }
            return n * Factorial(n - 1); //递归调用，计算阶乘
        }
        #endregion

        #region 练习题二
        //使用递归求1！+2！+3！+.......+ 10！的和
        static int SumFactorials(int n)
        {
            if (n <= 1) //终止条件
            {
                return 1; //如果n小于等于1，返回1
            }
            return Factorial(n) + SumFactorials(n - 1); //递归调用，计算当前阶乘加上前面的和
        }
        #endregion

        #region 练习题三
        //一根竹竿长100米，每天砍掉一半，求第十天的长度是多少
        static double BambooLength(int day)
        {
            if (day < 0) //终止条件
            {
                return 100; //如果天数小于等于0，返回初始长度100米
            }
            return BambooLength(day - 1) / 2; //递归调用，计算前一天的长度除以2
        }
        #endregion

        #region 练习题四
        //不允许使用循环语句、条件语句，在控制台打印出1-200这200个数
        static bool PrintNum(int num)
        {
            Console.WriteLine(num); //打印当前数字
            return num == 0 || PrintNum(num - 1); //递归调用，打印数字
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("递归函数!");
            PrintNumbers(10); //调用递归函数，从10开始打印数字
            Console.WriteLine($"5! = {Factorial(5)}"); //调用阶乘函数，计算5的阶乘
            Console.WriteLine($"1! + 2! + ... + 10! = {SumFactorials(10)}"); //调用求阶乘和函数，计算1到10的阶乘和
            Console.WriteLine($"第10天的竹竿长度 = {BambooLength(10)}米"); //调用竹竿长度函数，计算第10天的长度
            Console.WriteLine($"打印1-200的数字:{PrintNum(200)}");
        }
    }
}
