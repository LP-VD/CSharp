using System;
namespace Lesson9_选择排序
{
    class Program
    {
        #region 选择排序基本原理
        //新建中间商，依次比较，找出极值，放入目标位置，比较n轮
        #endregion   

        #region 选择排序代码实现
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            //遍历数组元素
            for (int i = 0; i < n - 1; i++)
            {
                //假设当前元素为最小值
                int minIndex = i;
                //在剩余元素中寻找更小值
                for (int j = i + 1; j < n; j++)
                {
                    // 如果找到更小的元素，则更新最小值索引
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // 如果最小值索引不是当前元素索引，则交换它们
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 6, 4 };
            SelectionSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}