using System;
namespace Lession8_冒泡排序
{
    class Program
    {
        #region 冒泡排序
        //int[] arr = { 5, 3, 8, 4, 2 }; //定义一个整数数组
        //冒泡排序函数
        static void BubbleSort(int[] arr)
        {
            Console.WriteLine("排序前的数组: " + string.Join(", ", arr)); //输出排序前的数组
            int n = arr.Length; //获取数组长度
            for (int i = 0; i < n - 1; i++) //外层循环控制比较轮数
            {
                for (int j = 0; j < n - i - 1; j++) //内层循环进行相邻元素比较
                {
                    if (arr[j] > arr[j + 1]) //如果前一个元素大于后一个元素
                    {
                        //交换两个元素的位置
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("排序后的数组: " + string.Join(", ", arr)); //输出排序后的数组
        }

        #endregion

        //排序函数，接受一个整数数组和一个布尔值参数，表示是否升序排序
        static int[] Sort(int[] arr, bool isAscendingOrder)
        {
            bool order;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    order = isAscendingOrder ? arr[j] > arr[j + 1] : arr[j] < arr[j + 1];
                    if (order)
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BubbleSort(new int[] { 5, 3, 8, 4, 2 }); //调用冒泡排序函数，传入一个整数数组
            Console.WriteLine();
            int[] arr2 = { 3, 7, 5, 8, 54, 3, 4, 2 };
            Sort(arr2, false);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i] + " ");
            }

        }
    }
}
