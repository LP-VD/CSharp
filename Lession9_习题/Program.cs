namespace Lession9_习题
{
    class Program
    {
        #region 练习题一
        //使用param参数，求多个数字的和以及平均值
        static void CalculateSum(params int[] numbers)
        {
            if(numbers.Length == 0)
            {
                Console.WriteLine("没有传入任何数字。");
                return; //如果没有传入数字，直接返回
            }
            int total = 0;
            foreach (var number in numbers)
            {
                total += number; //累加所有传入的数字
            }
            int average = total / numbers.Length; //计算平均值
            
            Console.WriteLine($"总和: {total}, 平均值: {average}"); //输出总和和平均值
        }
        #endregion

        #region 练习题二
        //使用param参数，求多个数字的偶数和奇数和
        static void CalculateSum1(params int[] numbers)
        {
            int evenSum = 0; //偶数和
            int oddSum = 0; //奇数和
            foreach (var number in numbers)
            {
                if (number % 2 == 0) //判断是否为偶数
                {
                    evenSum += number; //累加偶数
                }
                else
                {
                    oddSum += number; //累加奇数
                }
            }
            Console.WriteLine($"偶数和: {evenSum}, 奇数和: {oddSum}"); //输出偶数和奇数和
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CalculateSum();
            CalculateSum(1, 2, 3, 4, 5); //调用CalculateSum函数，传入多个参数
            CalculateSum1(1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ); //调用CalculateSum1函数，传入数组参数

        }
    }
}
