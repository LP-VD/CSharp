using System;

namespace Lesson1_Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 变量的存储空间
            // 变量分为有符号和无符号
            // 有符号变量：
            // sbyte：1字节，范围：-128 到 127
            // short：2字节，范围：-32,768 到 32,767
            // int：4字节，范围：-2,147,483,648 到 2,147,483,647
            // long：8字节，范围：-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807

            // 无符号变量：
            // byte：1字节，范围：0 到 255
            // ushort：2字节，范围：0 到 65,535
            // uint：4字节，范围：0 到 4,294,967,295
            // ulong：8字节，范围：0 到 18,446,744,073,709,551,615

            // 浮点数变量：
            // float：4字节，范围：±1.5 x 10^−45 到 ±3.4 x 10^38，精度约为7位十进制数
            // double：8字节，范围：±5.0 x 10^−324 到 ±1.7 x 10^308，精度约为15-16位十进制数
            // decimal：16字节，范围：±1.0 x 10^−28 到 ±7.9 x 10^28，精度约为28-29位十进制数

            // 特殊：
            // bool：1字节，表示true或false
            // char：2字节，表示单个Unicode字符，范围：'\u0000' 到 '\uffff'
            // string：引用类型，表示一系列字符，大小取决于字符串的长度

            // 空间转换
            // 1byte = 8 bits
            // 1KB = 1024 bytes
            // 1MB = 1024 KB
            // 1GB = 1024 MB
            // 1TB = 1024 GB
            // 通过sizeof()函数可以查看变量的存储空间大小
            #endregion

            #region 变量的本质
            //本质是2进制
            //数据传递只能通过电信号，只有开和关两种状态，抽象化为0和1
            //1bit（位）就是一个数，只能表示0或1
            #endregion

            #region 值类型和引用类型
            //值类型：变量直接存储数据值，常见的值类型有int、float、char、bool等
            //引用类型：变量存储的是数据的地址（引用），常见的引用类型有string、数组、类等
            //值类型存储在栈内存中，引用类型存储在堆内存中
            // 值类型变量赋值是将值复制一份，引用类型变量赋值是将地址复制一份
            // 值类型变量在使用时直接操作数据值，引用类型变量在使用时通过地址访问数据
            // 值类型变量在超出作用域后会自动释放，引用类型变量需要通过垃圾回收机制释放
            // 值类型变量存储空间较小，访问速度较快，引用类型变量存储空间较大，访问速度较慢
            // 值类型变量适合存储简单数据，引用类型变量适合存储复杂数据
            // 值类型变量在传递参数时是按值传递，引用类型变量在传递参数时是按引用传递
            // 值类型变量可以使用Nullable<T>类型表示可空类型，引用类型变量本身就可以为null
            // 值类型变量可以使用结构体（struct）定义自定义类型，引用类型变量可以使用类（class）定义自定义类型
            // 值类型变量在内存中连续存储，引用类型变量在内存中不一定连续存储
            // 值类型变量可以直接进行算术运算，引用类型变量需要先访问数据才能进行算术运算
            // 值类型变量可以使用默认值初始化，引用类型变量需要使用new关键字创建实例
            // 值类型变量在调试时可以直接查看值，引用类型变量在调试时需要先查看地址再查看值
            // 值类型变量在多线程环境下操作较安全，引用类型变量在多线程环境下操作需要加锁
            // 值类型变量在函数调用时开销较小，引用类型变量在函数调用时开销较大
            // 值类型变量适合存储临时数据，引用类型变量适合存储持久数据
            // 值类型变量在序列化时开销较小，引用类型变量在序列化时开销较大
            // 值类型变量在内存中分配较快，引用类型变量在内存中分配较慢
            // 值类型变量在内存中分配和释放较快，引用类型变量在内存中分配和释放较慢
            // 值类型变量在内存中存储位置固定，引用类型变量在内存中存储位置不固定

            int a = 10;
            int[] arr = { 1, 2, 3, 4, 5 };
            int b = a; //值类型变量赋值，复制值
            int[] arr2 = arr; //引用类型变量赋值，复制地址
            Console.WriteLine($"a={a}, b={b}"); //输出a=10, b=10
            Console.WriteLine($"arr[0]={arr[0]}, arr2[0]={arr2[0]}"); //输出arr[0]=1, arr2[0]=1

            b = 20; //修改b的值，不影响a
            arr2[0] = 10; //修改arr2的值，影响arr
            Console.WriteLine($"a={a}, b={b}"); //输出a=10
            Console.WriteLine($"arr[0]={arr[0]}, arr2[0]={arr2[0]}"); //输出arr[0]=10, arr2[0]=10

            //值类型在相互赋值时，实际是将值复制了一份
            //引用类型在相互赋值时，实际是将地址复制了一份
            #endregion

            #region String
            //字符串是引用类型，但表现得像值类型
            //字符串是不可变的，修改字符串实际上是创建了一个新的字符串对象
            string str1 = "Hello";
            string str2 = str1; //引用类型变量赋值，复制地址
            Console.WriteLine($"str1={str1}, str2={str2}"); //输出str1=Hello, str2=Hello
            str2 = "World"; //修改str2的值，实际上是创建了一个
            Console.WriteLine($"str1={str1}, str2={str2}"); //输出str1=Hello, str2=World
            //字符串的比较是比较值而不是地址
            Console.WriteLine($"str1 == str2: {str1 == str2}"); //输出str1 == str2: False
            Console.WriteLine($"str1.Equals(str2): {str1.Equals(str2)}"); //输出str1.Equals(str2): False
            //字符串的连接会创建新的字符串对象
            string str3 = str1 + " " + str2;
            Console.WriteLine($"str3={str3}"); //输出str3=Hello World
            //字符串的常用方法
            Console.WriteLine($"str3.Length={str3.Length}"); //输出str3.Length=11
            Console.WriteLine($"str3.ToUpper()={str3.ToUpper()}"); //输出str3.ToUpper()=HELLO WORLD
            Console.WriteLine($"str3.ToLower()={str3.ToLower()}"); //输出str3.ToLower()=hello world
            Console.WriteLine($"str3.Contains(\"lo\")={str3.Contains("lo")}"); //输出str3.Contains("lo")=True
            Console.WriteLine($"str3.IndexOf(\"o\")={str3.IndexOf("o")}"); //输出str3.IndexOf("o")=4
            Console.WriteLine($"str3.Substring(0, 5)={str3.Substring(0, 5)}"); //输出str3.Substring(0, 5)=Hello
            Console.WriteLine($"str3.Replace(\"Hello\", \"Hi\")={str3.Replace("Hello", "Hi")}"); //输出str3.Replace("Hello", "Hi")=Hi World
            
            #endregion

            Console.WriteLine("Hello World!");
            Console.WriteLine("PPP!");
        }
    }
}