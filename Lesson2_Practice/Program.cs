using System;

namespace Lession2_Practice

{
    enum E_QQType
    {
        // 三杠注释鼠标移上去会有说明
        /// <summary>
        /// 在线
        /// </summary>  
        Online,
        Leave,
        Busy,
        Invisible,
    }

    enum E_CoffeeType
    {
            M,
            B,
            S,
    }

    enum E_sex
    {
        Man,
        Woman,
    }

    enum E_Occuption
    {
        Warrior,
        Master,
        Hunter,
    }

    class Program
     {
        static void Main(string[] args)
        {
         Console.WriteLine("枚举练习题");
            #region 练习题一
            ///定义QQ状态枚举，提示用户选择一个在线状态，接受输入的数字，将其转换未枚举类型
            try
            {
                Console.WriteLine("请输入QQ的状态：0在线，1离开，2忙，3隐身");
                int type = int.Parse(Console.ReadLine());
                E_QQType qqType = (E_QQType)type; //将整数转换为枚举
                Console.WriteLine($"你选择的QQ状态是：{qqType}"); //输出对应的枚举值
            }
            catch
            {
                Console.WriteLine("请输入数字：");
            }
            #endregion

            #region 练习题二
            //用户去买咖啡，有中杯（35元）、大杯（45元）、特大杯（55元）三种选择
            //请用户选择购买类型，用户选择后打印：您购买了xxx咖啡，花费了xx元
            try
            {
                Console.WriteLine("请选择咖啡类型：0中杯，1大杯，2特大杯");
                int CoffeeType = int.Parse(Console.ReadLine());
                E_CoffeeType coffeeType = (E_CoffeeType)CoffeeType; //将整数转换为枚举
                switch (coffeeType)
                {
                        case E_CoffeeType.M:
                        Console.WriteLine($"您购买了中杯咖啡，花费了35元");
                        break;
                        case E_CoffeeType.B:
                        Console.WriteLine($"您购买了大杯咖啡，花费了45元");
                        break;
                        case E_CoffeeType.S:
                        Console.WriteLine($"您购买了特大杯咖啡，花费了55元");
                        break;
                    default:
                        Console.WriteLine("未知咖啡类型");
                        break;
                }

            }
            catch
            {
                Console.WriteLine("请输入数字：");
            }
            #endregion

            #region 练习题三
            //请用户选择英雄性别和职业，最后打印英雄的基本属性（性别、职业、攻击力、生命值）
            //性别：
            //男：攻击力+50，防御力+100
            //女：攻击力+150，防御力+20
            //职业：
            //战士：攻击力+200，防御力+100，技能：肉蛋葱鸡
            //法师：攻击力+100，防御力+50，技能：我CNM
            //猎人：攻击力+50，防御力+200，技能：无量天尊
            try
            {
                Console.WriteLine("请选择英雄性别：0男，1女");
                E_sex heroSex = (E_sex)int.Parse(Console.ReadLine()); //将整数转换为枚举
                string sexStr = "";
                int atk = 0;
                int def = 0;
                switch (heroSex)
                {
                    case E_sex.Man:
                        sexStr = "男";
                        atk = 50;
                        def = 100;
                        break;
                    case E_sex.Woman:
                        sexStr = "女";
                        atk = 150;
                        def = 20;
                        break;
                }
                Console.WriteLine("请选择英雄职业：0战士，1法师，2猎人");
                E_Occuption heroOccuption = (E_Occuption)int.Parse(Console.ReadLine()); //将整数转换为枚举
                string Skill = "";
                string Occuption = "";
                switch (heroOccuption)
                {
                    case E_Occuption.Warrior:
                        Skill = "肉蛋葱鸡";
                        atk += 200;
                        def += 100;
                        Occuption = "战士";
                        break;
                    case E_Occuption.Master:
                        Skill = "我CNM";
                        atk += 100;
                        def += 50;
                        Occuption = "法师";
                        break;
                    case E_Occuption.Hunter:
                        Skill = "无量天尊";
                        atk += 50;
                        def += 200;
                        Occuption = "猎人";
                        break;
                    default:
                                                Console.WriteLine("未知职业");
                        break;
                }
                Console.WriteLine($"英雄性别：{sexStr}，职业：{Occuption}，攻击力：{atk}，防御力：{def}，技能：{Skill}");
            }
            catch
            {
                Console.WriteLine("请输入数字：");
            }            
            #endregion
        }
    }
}