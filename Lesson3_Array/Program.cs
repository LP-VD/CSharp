using System;
namespace Lession3_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 知识点一 基本概念
            //数组是存储一组相同类型数据的集合。
            #endregion

            #region 知识点二 数组的申明
            //变量类型[] 数组名；//只是申明了一个数组，但没有分配内存空间
            int[ ] arr1; //申明了一个整型数组变量arr1
            //变量类型[] 数组名 = new 变量类型[数组长度]；//申明了一个数组，并分配了内存空间
            int[ ] arr2 = new int[5]; //申明了一个长度为5的整型数组arr2
            //变量类型[] 数组名 = new 变量类型[数组长度（可省略）]{元素1, 元素2, ...}; 
            //申明了一个数组，并分配了内存空间，同时初始化数组
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 }; //申明了一个长度为5的整型数组arr3，并初始化了数组元素
            //申明了一个长度为5的整型数组arr4，并初始化了数组元素（省略了new int[5]）
            int[] arr4 = { 1, 2, 3, 4, 5 };

            #endregion

            #region 知识点三 数组的使用
            int[ ] array = {1,2,3,4,5}; //申明并初始化一个整型数组
            //1. 数组的长度
            Console.WriteLine($"数组的长度为：{array.Length}"); //输出数组的长度
            //2. 访问数组元素
            //数组的索引从0开始，所以访问第一个元素时使用索引0
            Console.WriteLine($"数组的第一个元素为：{array[0]}"); //访问数组的第一个元素
            //3. 修改数组元素
            array[0] = 8; //将数组的第一个元素修改为8
            Console.WriteLine($"修改后的数组的第一个元素为：{array[0]}"); //输出修改后的数组的第一个元素
            //4. 遍历数组
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"数组的第{i + 1}个元素为：{array[i]}"); //遍历数组并输出每个元素
            }
            Console.WriteLine("----------------------");
            //5.增加数组元素
            int[ ] array2 = new int[6]; //创建一个新的数组，长度为6
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i]; //将原数组的元素复制到新数组
            }
            array2[5] = 6; //在新数组的最后一个位置添加一个新元素6
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"数组的第{i + 1}个元素为：{array2[i]}"); //遍历数组并输出每个元素
            }
            //6.删除数组元素
            int[ ] array3 = new int[5]; //创建一个新的数组，长度为5
            for (int i = 0; i < array2.Length - 1; i++)
            {
                array3[i] = array2[i]; //将原数组的元素复制到新数组，删除最后一个元素
            }
            Console.WriteLine("----------------------");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine($"数组的第{i + 1}个元素为：{array3[i]}"); //遍历数组并输出每个元素
            }
            //7.查找数组元素
            int a = 3; //要查找的元素
            for (int i = 0; i < array3.Length; i++)
            {
                if (a == array3[i])
                {
                    Console.WriteLine($"数组中存在元素{a}，索引为{i}"); //如果找到元素，则输出其索引
                    break; //找到后退出循环
                }
            }
            #endregion

        }
    }
}
