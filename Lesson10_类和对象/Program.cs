using System;
namespace Lesson10_类和对象
{

    #region 知识点一：类的基本概念
    //类申明在namespace下
    //特征：属性（字段、属性）
    //行为：方法（函数）
    //类的申明和类对象的申明是两个概念
    //类的申明：class 类名 {属性、方法}
    //类对象的申明：类名 对象名 = new 类名();类创建对象的过程一般称为实例化的过程
    //类是引用类型
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个Person类的对象；
            Person person = new Person();
            person.Name = "张三";
            person.Age = 25;
            person.SayHello();

            // 创建另一个Person类的对象
            Person anotherPerson = new Person();
            anotherPerson.Name = "李四";
            anotherPerson.Age = 30;
            anotherPerson.SayHello();

            // 比较两个对象的引用
            Person p1 = new Person();
            Person p2 = p1; // p2引用了p1所引用的对象，此时p1和p2指向同一个对象
            p2 = new Person(); // p2现在引用一个新的对象，p1仍然引用原来的对象
            Console.WriteLine(p1 == p2); // 输出False，因为p1和p2引用不同的对象
        }
    }
    #region 知识点二：类申明实例
    // 定义一个Person类
    class Person
    {
        // 定义属性
        public string Name { get; set; }
        public int Age { get; set; }

        // 定义方法
        public void SayHello()
        {
            Console.WriteLine($"大家好，我是{Name}，今年{Age}岁。");
        }
    }
    #endregion
}
