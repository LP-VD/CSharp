using System;
namespace Lesson05_变长参数和参数默认值
{
    class Program
    {

        #region 知识点一 变长参数关键字
        //params关键字用于定义变长参数，可以接收任意数量的参数
        //params关键字后面必为数组类型
        //数组的类型可以是任意类型
        //函数参数可以有别的参数和params关键字修饰的参数
        //函数参数中只能有一个params参数，并且一定是在最后一个参数位置
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (var number in numbers)
            {
                total += number; //累加所有传入的数字
            }
            return total; //返回总和 
        }
        #endregion

        #region 知识点二 参数默认值
        //有参数默认值的函数，一般称为可选参数
        //作用是 当调用函数时，如果没有传入该参数，则使用默认值
        static void Speak11(string str = "Hello, World!")
        {
            Console.WriteLine(str); //输出消息
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); //调用Sum函数，传入多个参数
            Speak11("123123"); //调用Speak11函数，传入自定义消息
            Speak11(); //调用Speak11函数，不传入参数，使用默认值
        }
    }
}
