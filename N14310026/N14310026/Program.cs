using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14310026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student student = new Student();
            student.id = "N14310026";
            student.name = "廖宇翔";
            Console.WriteLine("ID:" + student.id + "Name:" + student.name);

            Student student2 = new Student();
            student2.id = "N00001111";
            student2.name = "老王";
            Console.WriteLine("ID:" + student2.id + "Name:" + student2.name);*/
            Student student3 = new Student("N1234567" , "姚");
            student3.Print();
            Console.ReadLine();
        }
    }
    public class Student 
    {
        public string id;
        public string name;
        public Student(string id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine("ID:" + this.id + "Name:" + this.name);

        }
    
    
    }

   

}
