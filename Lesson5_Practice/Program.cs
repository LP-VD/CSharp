using System.Runtime.ConstrainedExecution;

namespace Lession5_Practice
{
    internal class Program
    {

        #region ref和out的区别
        //ref的使用 传入的参数必须在调用前初始化；out不用
        //out的使用 在内部必须给传入的参数赋值；ref不需要
        #endregion

        #region 练习题
        //让用户输入用户名和密码，返回给用户一个bool类型的登录结果，并且单独返回给用户一个登录信息
        //若用户名错误，除了返回登录结果外，登录信息为“用户名错误”；
        //若密码错误，除了返回登录结果外，登录信息为“密码错误”；
        //若用户名和密码都正确，登录信息为“登录成功”。

        static bool CheckLogin(string username, string password, ref string info)
        {
            if(username == "admin" && password == "123456")
            {
                info = "登录成功";
                return true;
            }
            else if(username != "admin")
            {
                info = "用户名错误";
                return false;
            }
            else
            {
                info = "密码错误";
                return false;
            }
        }
        #endregion

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
            Console.WriteLine("-------------");

            Console.Write("请输入用户名: ");
            string username = Console.ReadLine();
            Console.Write("请输入密码: ");
            string password = Console.ReadLine();

            string info = string.Empty; // 初始化info变量

            while (!CheckLogin(username, password, ref info))
            {
                Console.WriteLine(info); // 输出登录信息
                Console.Write("请重新输入用户名: ");
                username = Console.ReadLine();
                Console.Write("请重新输入密码: ");
                password = Console.ReadLine();
            }
            Console.WriteLine(info); // 输出登录成功信息

        }
    }
}
