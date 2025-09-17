using System;
namespace Lession04_Function
{
    class Program
    {
        #region 知识点一 基本概念
        //函数（方法）
        //函数是一个有名字的代码块，可以被调用来执行特定的任务。
        //函数（方法）是封装代码进行重复使用的一种机制
        //主要作用
        //1. 封装代码
        //2. 提高代码复用性
        //3. 抽象
        #endregion

        #region 知识点二 写在哪里
        //1. 函数可以写在类中
        //2. 可以写在Struct中
        #endregion

        #region 知识点三 基本语法
        // static 返回类型 函数名(参数类型 参数名1，参数类型 参数名2，...)
        // {
        //          函数的代码逻辑；
        //          ...............
        //          //如果函数没有返回值，则不需要使用return语句  
        //          return 返回值; //如果函数有返回值，则需要使用return语句返回一个值
        //          //返回类型可以写任意类型
        // }
        #endregion

        #region 知识点四 实际应用
        //1. 无参无返回值函数
        static void SayHello()
        {
            Console.WriteLine("Hello, CSharp!");
        }
        //2. 有参无返回值函数
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        //3. 无参有返回值函数
        static string WhatYourName()
        {
            return "CCCCC";
        }
        //4. 有参有返回值函数
        static int Add(int a, int b)
        {
            return a + b; // 返回两个整数的和
        }
        //5. 可变参数函数
        static void PrintNumbers(params int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        #endregion

        #region 知识点五 关于return
        //函数没有返回值时，也可以使用return
        //return可以直接不执行之后的代码，直接返回到函数外部
        static void Speak(string str)
        {
            if (str == "11")
            {
                return;
            }
            Console.WriteLine(str);
        }
        #endregion

        #region 知识点六 函数重载
        //函数重载（Overloading）
        //函数重载是指在同一个类中，允许存在多个同名但参数列表不同的函数。
        //参数列表不同可以是参数类型不同，参数个数不同，参数顺序不同
        //函数重载的好处
        //1. 提高代码的可读性
        //2. 提高代码的复用性
        //3. 提高代码的灵活性
        //重载一个函数，让其可以比较两个int或两个float或两个double的大小
        static int Compare(params int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("至少需要两个整数进行比较。"); //如果传入的数组长度小于2，抛出异常
            }
            int max = arr[0]; //假设第一个数为最大值
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) //如果当前数大于最大值
                {
                    max = arr[i]; //更新最大值
                }
            }
            return max; //返回最大值
        }
        static double Compare(params double[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("至少需要两个整数进行比较。"); //如果传入的数组长度小于2，抛出异常
            }
            double max = arr[0]; //假设第一个数为最大值
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) //如果当前数大于最大值
                {
                    max = arr[i]; //更新最大值
                }
            }
            return max; //返回最大值
        }
        static float Compare(params float[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("至少需要两个整数进行比较。"); //如果传入的数组长度小于2，抛出异常
            }
            float max = arr[0]; //假设第一个数为最大值
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) //如果当前数大于最大值
                {
                    max = arr[i]; //更新最大值
                }
            }
            return max; //返回最大值
        }       

            #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SayHello();
            PrintMessage("Hello, CSharp with parameters!");
            Console.Write(WhatYourName());
            Console.Write(Add(5, 10));
            PrintNumbers(new[] { 5, 10, 15, 20 });
            Speak("22");
            Speak("11");

            Console.WriteLine("-----------");
            Console.WriteLine(Compare(1, 2, 3, 6, 78)); //调用Compare函数，传入两个整数
            Console.WriteLine(Compare(1.5f, 2.5f, 5.6f)); //调用Compare函数，传入两个浮点数
            Console.WriteLine(Compare(1.5, 2.5, 5.5)); //调用Compare函数，传入两个双精度浮点数

        }
        }
    }

