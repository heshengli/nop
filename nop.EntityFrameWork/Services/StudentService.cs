using nop.EntityFrameWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nop.EntityFrameWork.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _iStudentRepository;
        private readonly IDbContext _iDbContext;
        public StudentService()
        {
            _iDbContext = new ObjectContext("App");
            _iStudentRepository = new EfRepository<Student>(_iDbContext);

        }

        //Autofac ctor
        //public StudentService(IRepository<Student> iStudentRepositpory,IDbContext iDbContext)
        //{
        //    _iDbContext = iDbContext;
        //    _iStudentRepository = iStudentRepositpory;
        //}

        public void Delete(int id)
        {
            _iStudentRepository.Delete(id);
        }

        public IEnumerable<Student> GetList()
        {
            return _iStudentRepository.Table.AsEnumerable();
        }

        public void Insert(Student stu)
        {
            _iStudentRepository.Insert(stu);
        }

        public void Update(Student stu)
        {
            _iStudentRepository.Update(stu);
        }
    }
}
