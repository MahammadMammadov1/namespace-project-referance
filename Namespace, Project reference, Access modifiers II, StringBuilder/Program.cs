using Core.Models;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Group = Core.Models.Group;

namespace Namespace__Project_reference__Access_modifiers_II__StringBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("AA206", 13);//eger kicik herfle ve ya 5 den artiq simvol daxil etseniz  xeta verecek


            Student student1 = new Student("Ali Memmedov");
            student1.GroupNo = "BB206";//Bunlar ise sadece isleyib islememeyini yoxlamaq ucundu 
            student1.AvgPoint = 85.5;


            group.AddStudent(student1);


            Student student2 = new Student("Nigar Qasimova");
            student2.GroupNo = "BB206";
            student2.AvgPoint = 90.2;


            group.AddStudent(student2);


            Console.WriteLine("Sinifdeki telebeler :");
            foreach (var student in group.Students)
            {
                if (student != null)
                {
                    Console.WriteLine($"Adı Soyadı: {student.FullName} -  GrupNo: {student.GroupNo} - Ortalama: {student.AvgPoint}");
                }
            }
        }
    }
}