using System.Runtime.ConstrainedExecution;

namespace Lession9_练习题
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("请输入用户名: ");
            string username = Console.ReadLine();
            Console.Write("请输入密码: ");
            string password = Console.ReadLine();

            string info = string.Empty; // 初始化info变量

            while(!CheckLogin(username, password, ref info))
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
