using System;
namespace Lession7_函数
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

        }
    }
}
