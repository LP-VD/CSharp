using System;
namespace Lession03_Array
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
            int[] arr1; //申明了一个整型数组变量arr1
            //变量类型[] 数组名 = new 变量类型[数组长度]；//申明了一个数组，并分配了内存空间
            int[] arr2 = new int[5]; //申明了一个长度为5的整型数组arr2
            //变量类型[] 数组名 = new 变量类型[数组长度（可省略）]{元素1, 元素2, ...}; 
            //申明了一个数组，并分配了内存空间，同时初始化数组
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 }; //申明了一个长度为5的整型数组arr3，并初始化了数组元素
            //申明了一个长度为5的整型数组arr4，并初始化了数组元素（省略了new int[5]）
            int[] arr4 = { 1, 2, 3, 4, 5 };

            #endregion

            #region 知识点三 数组的使用
            int[] array = { 1, 2, 3, 4, 5 }; //申明并初始化一个整型数组
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
            int[] array2 = new int[6]; //创建一个新的数组，长度为6
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
            int[] array3 = new int[5]; //创建一个新的数组，长度为5
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

            #region 知识点四 多维数组
            //使用多个下标来表示数组的维度
            //申明格式：
            //变量类型[,] 数组名 = new 变量类型[行数, 列数]；//申明了一个二维数组，并分配了内存空间 
            int[,] arr5 = new int[3, 4]; //申明了一个3行4列的二维整型数组arr5

            //多维数组的使用
            int[,] array4 = { { 1, 2, 3 },
                                { 4, 5, 6 },
                                { 7, 8, 9 } };

            //1. 获取二维数组的行数和列数
            int rows = array4.GetLength(0); //获取二维数组的行数
            int cols = array4.GetLength(1); //获取二维数组的列数
            Console.WriteLine($"二维数组的行数为：{rows}，列数为：{cols}");
            //2. 访问二维数组元素
            //注意：二维数组的索引也是从0开始的
            Console.WriteLine($"二维数组的第1行第2列的元素为：{array4[0, 1]}"); //访问二维数组的第1行第2列
            //3. 修改二维数组元素
            array4[0, 1] = 20; //将二维数组的第1行第2列的元素修改为20
            Console.WriteLine($"修改后的二维数组的第1行第2列的元素为：{array4[0, 1]}"); //输出修改后的二维数组的第1行第2列
            //4. 遍历二维数组
            for (int i = 0; i < rows; i++) //遍历行
            {
                for (int j = 0; j < cols; j++) //遍历列
                {
                    Console.Write($"{array4[i, j]} "); //输出二维数组的每个元素
                }
                Console.WriteLine(); //换行
            }
            //5. 增加二维数组元素
            //二维数组的大小是固定的，不能动态增加元素
            //可以通过创建一个新的二维数组，并将原数组的元素复制到新数组
            int[,] array5 = new int[4, 4]; //创建一个新的4行4列的二维数组
            for (int i = 0; i < rows; i++) //遍历原数组的行
            {
                for (int j = 0; j < cols; j++) //遍历原数组的列
                {
                    array5[i, j] = array4[i, j]; //将原数组的元素复制到新数组
                }
            }
            array5[3, 0] = 10; //在新数组的第4行第1列添加一个新元素10
            Console.WriteLine("增加元素后的二维数组：");
            for (int i = 0; i < 4; i++) //遍历新数组的行
            {
                for (int j = 0; j < 4; j++) //遍历新数组的列
                {
                    Console.Write($"{array5[i, j]} "); //输出新数组的每个元素
                }
                Console.WriteLine(); //换行
            }
            //6. 删除二维数组元素
            //二维数组的大小是固定的，不能动态删除元素
            //可以通过创建一个新的二维数组，并将原数组的元素复制到新数组
            int[,] array6 = new int[3, 3]; //创建一个新的3行3列的二维数组
            for (int i = 0; i < 3; i++) //遍历原数组的前3行
            {
                for (int j = 0; j < 3; j++) //遍历原数组的前3列
                {
                    array6[i, j] = array5[i, j]; //将原数组的元素复制到新数组
                }
            }
            Console.WriteLine("删除元素后的二维数组：");
            for (int i = 0; i < 3; i++) //遍历新数组的行
            {
                for (int j = 0; j < 3; j++) //遍历新数组的列
                {
                    Console.Write($"{array6[i, j]} "); //输出新数组的每个元素
                }
                Console.WriteLine(); //换行
            }
            //7. 查找二维数组元素
            int b = 5; //要查找的元素
            bool found = false; //标记是否找到元素
            for (int i = 0; i < 3; i++) //遍历行
            {
                for (int j = 0; j < 3; j++) //遍历列
                {
                    if (array6[i, j] == b) //如果找到元素
                    {
                        Console.WriteLine($"二维数组中存在元素{b}，位置为：第{i + 1}行，第{j + 1}列"); //输出元素的位置
                        found = true; //标记为找到
                        break; //退出内层循环
                    }
                }
                if (found) //如果已经找到元素
                {
                    break; //退出外层循环
                }
            }
            if (!found) //如果没有找到元素
            {
                Console.WriteLine($"二维数组中不存在元素{b}"); //输出未找到的信息
            }
            #endregion

        }
    }
}
