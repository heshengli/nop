using nop.EntityFrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.EntityFrameWork.Services
{
    public interface IStudentService
    {
        void Insert(Student stu);
        void Update(Student stu);
        void Delete(int id);
        IEnumerable<Student> GetList();
    }
}
