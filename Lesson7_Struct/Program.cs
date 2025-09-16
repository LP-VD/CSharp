using System;
namespace Lession7_Struct
{
    #region 概念
    //结构体是一种值类型，类似于类，但更轻量级
    //用来表现存在关系的数据集合
    //结构体一般写在namespace语句块中
    //结构体关键字 struct


    struct Student
    {
        //public 公有的，可以在结构体外部访问
        //private 私有的，只能在结构体内部访问
        //protected 受保护的，只能在结构体内部或派生结构体中访问
        //默认不写为private
        public string name;
        public int age;
        string studentId;

        public void SetStudentId(string id)
        {
            studentId = id; //设置学生ID

        }
        public void display()
        {
            Console.WriteLine($"学生姓名: {name}, 年龄: {age}, 学生ID: {studentId}"); //输出学生信息
        }
        #endregion


        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("结构体!");
                Student student = new Student();
                student.name = "张三"; //设置学生姓名
                student.age = 20; //设置学生年龄
                student.SetStudentId("123"); //设置学生ID
                student.display(); //调用display方法输出学生信息
                Console.WriteLine($"学生姓名: {student.name}, 年龄: {student.age},学生ID:{student.SetStudentId}"); //输出学生信息
            }
        }
    }
}
