namespace Lession10_练习题
{
    class Program
    {
        #region 
        //重载一个函数，让其可以比较两个int或两个float或两个double的大小
        static int Compare(params int[ ] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("至少需要两个整数进行比较。"); //如果传入的数组长度小于2，抛出异常
            }
            int max = arr[0]; //假设第一个数为最大值
            for ( int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) //如果当前数大于最大值
                {
                    max = arr[i]; //更新最大值
                }
            }
            return max; //返回最大值
        }
        static double Compare(params double [] arr)
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
            Console.WriteLine(Compare(1, 2,3,6,78)); //调用Compare函数，传入两个整数
            Console.WriteLine(Compare(1.5f, 2.5f,5.6f)); //调用Compare函数，传入两个浮点数
            Console.WriteLine(Compare(1.5, 2.5,5.5)); //调用Compare函数，传入两个双精度浮点数
        }
    }
}
