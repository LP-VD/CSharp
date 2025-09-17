using System;
namespace Lesson07_Practice
{
    #region 练习题一 
    //使用结构体，定义一个学生结构体，包含姓名、年龄、学号等属性
    //创建两个学生对象，分别赋值并输出
    struct Student
    {
        public string Name; //学生姓名
        public int Age; //学生年龄
        public string StudentId; //学生学号
        public Student(string name, int age, string studentId)
        {
            Name = name; //构造函数初始化姓名
            Age = age; //构造函数初始化年龄
            StudentId = studentId; //构造函数初始化学号
        }
        public void Display() //显示学生信息的方法
        {
            Console.WriteLine($"学生姓名: {Name}, 年龄: {Age}, 学号: {StudentId}");
        }
    }
    #endregion

    #region 练习题二
    //使用结构体描述矩形的信息，包含长和宽两个属性
    //定义一个方法，计算矩形的面积和周长
    struct Rectangle
    {
        public double Length; //矩形的长
        public double Width; //矩形的宽
        public Rectangle(double length, double width)
        {
            Length = length; //构造函数初始化长
            Width = width; //构造函数初始化宽
        }
        public double Area() //计算面积的方法
        {
            return Length * Width; //面积 = 长 * 宽
        }
        public double Perimeter() //计算周长的方法
        {
            return 2 * (Length + Width); //周长 = 2 * (长 + 宽)
        }
    }
    #endregion

    #region 练习题三
    //使用结构体描述玩家信息，玩家名字，玩家职业
    //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息
    //职业：
    //1.战士：（技能：冲锋，攻击力：100）
    //2.法师：（技能：火球，攻击力：80）
    //3.牧师：（技能：治疗，攻击力：50）
    //打印结果：法师刘海柱使用火球攻击，造成80点伤害
    struct Player
    {
        public string Name; //玩家姓名
        public string Profession; //玩家职业
        public int AttackPower; //攻击力
        public string Skill; //技能
        public Player(string name, string profession, int attackPower, string skill)
        {
            Name = name; //构造函数初始化姓名
            Profession = profession; //构造函数初始化职业
            AttackPower = attackPower; //构造函数初始化攻击力
            Skill = skill; //构造函数初始化技能
        }
        public void DisplayAttackInfo() //显示攻击信息的方法
        {
            Console.WriteLine($"{Profession} {Name} 使用 {Skill} 攻击，造成 {AttackPower} 点伤害");
        }
    }
    #endregion

    #region 练习题四 
    //使用结构体描述一个小怪兽
    struct Monster
    {
        public string Name; //小怪兽的名字
        public int AttackPower; //小怪兽的攻击力
        public Monster(string name, int attackPower)
        {
            Name = name; //构造函数初始化名字
            AttackPower = attackPower; //构造函数初始化攻击力
        }
    }
    #endregion

    #region 练习题五
    //定义一个数组存储10个上面描述的小怪兽，每个小怪兽的名字为：小怪兽+数组下标
    //最后打印10个小怪兽的名字和攻击力
    struct MonsterArray
    {
        public Monster[] Monsters; //小怪兽数组
        public MonsterArray(int size)
        {
            Monsters = new Monster[size]; //初始化小怪兽数组
            for (int i = 0; i < size; i++)
            {
                Monsters[i] = new Monster($"小怪兽{i}", 10 + i * 5); //创建小怪兽对象，名字为“小怪兽+下标”，攻击力递增
            }
        }
        public void DisplayMonsters() //显示小怪兽信息的方法
        {
            foreach (var monster in Monsters)
            {
                Console.WriteLine($"小怪兽名字: {monster.Name}, 攻击力: {monster.AttackPower}");
            }
        }
    }
    #endregion

    #region 练习题六 
    //应用已学知识，实现奥特曼打小怪兽
    //奥特曼有名字、攻击力、技能等属性
    struct Ultraman
    {
        public string Name; //奥特曼的名字
        public int AttackPower; //奥特曼的攻击力
        public string Skill; //奥特曼的技能
        public Ultraman(string name, int attackPower, string skill)
        {
            Name = name; //构造函数初始化名字
            AttackPower = attackPower; //构造函数初始化攻击力
            Skill = skill; //构造函数初始化技能
        }
        public void Attack(Monster monster) //攻击小怪兽的方法
        {
            Console.WriteLine($"{Name} 使用 {Skill} 攻击 {monster.Name}，造成 {AttackPower} 点伤害");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student student1 = new Student("张三", 20, "123456"); //创建第一个学生对象
            Student student2 = new Student("李四", 22, "654321"); //创建第二个学生对象
            student1.Display(); //输出第一个学生信息
            student2.Display(); //输出第二个学生信息
            Rectangle rectangle = new Rectangle(5.0, 3.0); //创建矩形对象
            Console.WriteLine($"矩形面积: {rectangle.Area()}"); //输出矩形面积
            Console.WriteLine($"矩形周长: {rectangle.Perimeter()}"); //输出矩形周长
            Player player1 = new Player("刘海柱", "法师", 80, "火球"); //创建玩家对象
            player1.DisplayAttackInfo(); //输出玩家攻击信息
            MonsterArray monsterArray = new MonsterArray(10); //创建小怪兽数组对象
            monsterArray.DisplayMonsters(); //输出小怪兽信息
            Ultraman ultraman = new Ultraman("奥特曼", 100, "光线"); //创建奥特曼对象
            foreach (var monster in monsterArray.Monsters) //遍历小怪兽数组
            {
                ultraman.Attack(monster); //奥特曼攻击每个小怪兽
            }
        }
    }
}
