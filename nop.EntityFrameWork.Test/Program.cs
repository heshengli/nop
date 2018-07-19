using nop.EntityFrameWork.Model;
using nop.EntityFrameWork.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.EntityFrameWork.Test
{
    class Program
    {
        private static readonly IStudentService _iStudentService = new StudentService();

        static void Main(string[] args)
        {
            Student stu = new Student() {
                Name="李四",
                CustomProperty="自定义属性2"
            };
            _iStudentService.Insert(stu);
            Console.WriteLine(stu.Name+"");
            Console.ReadKey();
        }
    }
}
