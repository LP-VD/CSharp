using System;

namespace Lession02_Enum
{
    #region 知识点一 基本概念
    //1. 枚举是什么？
    //是一个被命名的整型常量集合。
    //一般用器来表示状态、类型等

    //2. 申明枚举和申明枚举变量是两个概念
    //申明枚举是定义一个枚举类型
    //申明枚举变量是定义一个枚举类型的变量

    //3. 申明枚举语法
    //枚举名以E或E_开头
    enum E_自定义枚举名
    {
        E_枚举值1, // 默认值为0
        E_枚举值2, // 默认值为1
        E_枚举值3 = 10, // 指定值为10
        E_枚举值4 // 默认值为11
    }

    #endregion

    #region 知识点二 在哪里申明枚举
    ///1. namespace语句块中
    ///2. class语句块中 struct语句块中
    ///注意：枚举不能在函数语句块中申明！！
    enum E_MonsterType
    {
        Normal,//0
        Boss,//1
    }

    enum E_PlayerType
    {
        Main,
        Other,
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("枚举");

            #region 知识点三 枚举的使用
            //申明枚举变量
            //自定义的枚举类型 变量名 = 默认值；
            E_PlayerType playerType = E_PlayerType.Other;
            if(playerType == E_PlayerType.Main)
            {
                Console.WriteLine("主角逻辑");
            }
            else
            {
                Console.WriteLine("其他角色逻辑");
            }

            //枚举和switch是天生一队
            E_MonsterType monsterType = E_MonsterType.Boss;
            switch (monsterType)
            {
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("Boss怪物逻辑");
                    break;
                default:
                    Console.WriteLine("未知怪物逻辑");
                    break;
            }

            #endregion

            #region 知识点四 枚举的转换
            //1. 枚举和整数之间的转换
            int i = (int)playerType; //将枚举转换为整数
            Console.WriteLine(i); //输出0
            ///int转枚举
            playerType = 0; //将整数转换为枚举

            //2. 枚举和字符串之间的转换
            string str = playerType.ToString(); //将枚举转换为字符串
            Console.WriteLine(str); //输出Other
            ///把string转成枚举
            ///Parse后第一个参数是枚举类型的名称，第二个参数是要转换的字符串
            ///转换完成后是枚举类型的值，需要用括号强转成想要的目标枚举类型
            playerType = (E_PlayerType) Enum.Parse(typeof(E_PlayerType), "Other");
            Console.WriteLine(playerType); //输出Other
            ///枚举和枚举之间的转换
            ///枚举和对象之间的转换
            ///枚举和其他类型之间的转换
            #endregion

            #region 知识点五 枚举的作用
            //在游戏开发中，对象很多时候会有不同的状态、类型等，
            //比如玩家有一个动作状态，需要用一个变量或标识来表示玩家处于哪种状态 
            //枚举可以帮助我们更清晰地表达这些状态或类型，
            #endregion

        }
    }

 }
